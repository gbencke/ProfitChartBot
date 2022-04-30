using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProfitChartBotScanner
{
    public class ProfitChartBotScannerService : IProfitChartBotScannerService
    {
        private const int APITimeOut = 30000;
        private ProfitChartBotScannerStatus _ProfitChartBotState = ProfitChartBotScannerStatus.NonInitialized;
        private IObserverProfitChartBotScanner _Observer;
        private ModelParameters _ModelParameters;
        private ProfitChartScanHelper _scanner;
        private ProfitChartBotMLBasedConfiguration _configuration;
        private ProfitChartClickHelper _clickHelper;

        private Thread _scannerExecutionThread;
        private bool _shouldRun = false;
        private bool _useSmartStop = false;
        private int _minCaptureOffset = -10;
        private int _maxCaptureOffset = 10;
        private int _currentOffset = 0;

        private double? _longStop;
        private double? _longGain;
        private double? _shortStop;
        private double? _shortGain;
        public void StartExecution()
        {
            _shouldRun = true;
            _scannerExecutionThread = new Thread(ExecuteScanning);
            _scannerExecutionThread.Start();
        }

        public void Initialize(ProfitChartBotMLBasedConfiguration configuration, IObserverProfitChartBotScanner observer, bool useSmartStop)
        {
            if (_ProfitChartBotState != ProfitChartBotScannerStatus.NonInitialized)
            {
                throw new ProfitChartScannerInitializedException("Initialization has already been tried in this instance...");
            }

            _useSmartStop = useSmartStop;
            _Observer = observer;
            _configuration = configuration;
            _clickHelper = new ProfitChartClickHelper(_configuration);

            var ReceiveParametersThread = new Thread(() =>
            {
                var URL = configuration.GETParametersURL;

                _Observer.Observe(new Observation(ObservationType.ReadingParameters, "Lendo Parametros do Modelo do Servidor..."));
                _ProfitChartBotState = ProfitChartBotScannerStatus.RequestingParameters;

                try
                {
                    _ModelParameters = HTTPHelper.GetParameters(URL, APITimeOut);
                    _Observer.Observe(new Observation(ObservationType.ParametersRead, "Parametros do Modelo foram lidos do Servidor..."));
                    _ProfitChartBotState = ProfitChartBotScannerStatus.ParametersReceived;
                }
                catch (Exception ex)
                {
                    _Observer.Observe(new Observation(ObservationType.ErrorInReadingParameters, "Erro na Leitura dos Parametros:" + ex.Message));
                    _ProfitChartBotState = ProfitChartBotScannerStatus.ParametersError;
                }

            });

            ReceiveParametersThread.Start();
        }

        private ProfitChartScanResult GetNextScan()
        {

            ProfitChartScanResult nextResult = _scanner.GetNextScan(_currentOffset);
            if (nextResult == null)
            {
                ProfitChartScannerLogging.Debug(String.Format("Error in Scanning the Data..."));

                for (int currentOffset = _minCaptureOffset; currentOffset <= _maxCaptureOffset; currentOffset++)
                {
                    _currentOffset = currentOffset;
                    nextResult = _scanner.GetNextScan(_currentOffset);
                    if (nextResult != null)
                    {
                        ProfitChartScannerLogging.Debug(String.Format("Current Offset:{0}", _currentOffset));
                        break;
                    }
                }

                if (nextResult == null)
                {
                    ProfitChartScannerLogging.Debug("Error in Scanning the Data...");
                }
            }

            return nextResult;
        }


        public void ExecuteScanning()
        {
            ProfitChartBotOrderStatus _currentStatus = ProfitChartBotOrderStatus.Liquid;
            ProfitChartScanResult _lastResult = null;

            _Observer.Observe(new Observation(ObservationType.RunningScanner, "Running the Scanning for ProfitChart"));
            _ProfitChartBotState = ProfitChartBotScannerStatus.Running;
            _scanner = new ProfitChartScanHelper(_configuration, _ModelParameters);

            while (_shouldRun)
            {
                Thread.Sleep(_configuration.IntervalScanning.Value);

                var nextResult = GetNextScan();

                if (!(nextResult is null))
                {

                    if ((!(_lastResult is null)) && _lastResult.Equals(nextResult))
                    {
                        continue;
                    }

                    _Observer.Observe(new Observation(ObservationType.ScanResult, nextResult, _currentStatus));

                    // Stop Handling

                    if (_currentStatus == ProfitChartBotOrderStatus.Long && nextResult.ProfitChartLow.Value <= _longStop.Value)
                    {
                        ProfitChartScannerLogging.LogResult(nextResult);
                        _clickHelper.SendOpenCloseAllPositionsClick();
                        ProfitChartScannerLogging.Debug("(Order)Stop for Long Position:Click Sent...");
                        _longStop = null;
                        _longGain = null;
                        _currentStatus = ProfitChartBotOrderStatus.Liquid;
                        _Observer.Observe(new Observation(ObservationType.ScanResult, nextResult, _currentStatus));
                    }
                    if (_currentStatus == ProfitChartBotOrderStatus.Long && nextResult.ProfitChartHigh.Value >= _longGain.Value)
                    {
                        ProfitChartScannerLogging.LogResult(nextResult);
                        _clickHelper.SendOpenCloseAllPositionsClick();
                        ProfitChartScannerLogging.Debug("(Order)Gain for Long Position:Click Sent...");
                        _longStop = null;
                        _longGain = null;
                        _currentStatus = ProfitChartBotOrderStatus.Liquid;
                        _Observer.Observe(new Observation(ObservationType.ScanResult, nextResult, _currentStatus));
                    }

                    if (_currentStatus == ProfitChartBotOrderStatus.Short && nextResult.ProfitChartHigh.Value >= _shortStop.Value)
                    {
                        ProfitChartScannerLogging.LogResult(nextResult);
                        _clickHelper.SendOpenCloseAllPositionsClick();
                        ProfitChartScannerLogging.Debug("(Order)Stop for Short Position:Click Sent...");
                        _shortStop = null;
                        _shortGain = null;
                        _currentStatus = ProfitChartBotOrderStatus.Liquid;
                        _Observer.Observe(new Observation(ObservationType.ScanResult, nextResult, _currentStatus));
                    }

                    if (_currentStatus == ProfitChartBotOrderStatus.Short && nextResult.ProfitChartLow.Value <= _shortGain.Value)
                    {
                        ProfitChartScannerLogging.LogResult(nextResult);
                        _clickHelper.SendOpenCloseAllPositionsClick();
                        ProfitChartScannerLogging.Debug("(Order)Gain for Short Position:Click Sent...");
                        _shortStop = null;
                        _shortGain = null;
                        _currentStatus = ProfitChartBotOrderStatus.Liquid;
                        _Observer.Observe(new Observation(ObservationType.ScanResult, nextResult, _currentStatus));
                    }

                    // Next Quote Handling

                    if ((!(_lastResult is null)) && _lastResult.ProfitChartTime == nextResult.ProfitChartTime)
                    {
                        continue;
                    }

                    if (nextResult.ProfitChartRealTime.Value <= _ModelParameters.MaximumTime &&
                        nextResult.ProfitChartRealTime.Value >= 900)
                    {
                        ProfitChartScannerLogging.Debug("Posting:");
                        ProfitChartScannerLogging.LogResult(nextResult);
                        HTTPHelper.PostQuote(_configuration.POSTQuoteURL, new QuoteToPost(nextResult), APITimeOut);
                    }


                    if (nextResult.ProfitChartRealTime.Value > _ModelParameters.MinimumTime &&
                        nextResult.ProfitChartRealDate.Value >= _ModelParameters.MinimumDateTrade &&
                        nextResult.ProfitChartRealTime.Value <= _ModelParameters.MaximumTime)
                    {
                        var Decision = HTTPHelper.GetSignal(_configuration.GETPredictionURL,
                            _ModelParameters.CurrentExchange,
                            _ModelParameters.CurrentAsset,
                            _ModelParameters.CurrentTimeFrame,
                            nextResult.ProfitChartRealDate.Value.ToString(),
                            nextResult.ProfitChartRealTime.Value.ToString(),
                            APITimeOut);

                        ProfitChartScannerLogging.Debug(String.Format("(Predicted):Long ({0:0.000}), Short ({1:0.000})", Decision.LongPredict, Decision.ShortPredict));

                        nextResult.LongPredicted = Decision.LongPredict;
                        nextResult.ShortPredicted = Decision.ShortPredict;

                        _Observer.Observe(new Observation(ObservationType.ScanResult, nextResult, _currentStatus));

                        if (_currentStatus == ProfitChartBotOrderStatus.Liquid)
                        {

                            if (Decision.LongPredict > Decision.ShortPredict &&
                                Decision.LongPredict > _ModelParameters.DecisionBoundary)
                            {
                                _clickHelper.SendOpenLongPositionClick();
                                _longStop = nextResult.ProfitChartLastClose.Value * (1 - (_ModelParameters.CurrentStop / 100));
                                _longGain = nextResult.ProfitChartLastClose.Value * (1 + (_ModelParameters.CurrentTarget / 100));
                                ProfitChartScannerLogging.Debug(String.Format("(Order)Start Long Position... Click Sent... Target:{0}, Stop:{1}", _longGain, _longStop));
                                _currentStatus = ProfitChartBotOrderStatus.Long;
                                _Observer.Observe(new Observation(ObservationType.ScanResult, nextResult, _currentStatus));
                            }

                            if (Decision.ShortPredict > Decision.LongPredict &&
                                Decision.ShortPredict > _ModelParameters.DecisionBoundary)
                            {
                                _clickHelper.SendOpenShortPositionClick();
                                _shortStop = nextResult.ProfitChartLastClose.Value * (1 + (_ModelParameters.CurrentStop / 100));
                                _shortGain = nextResult.ProfitChartLastClose.Value * (1 - (_ModelParameters.CurrentTarget / 100));
                                ProfitChartScannerLogging.Debug(String.Format("(Order)Start Short Position... Click Sent... Target:{0}, Stop:{1}", _shortGain, _shortStop));
                                _currentStatus = ProfitChartBotOrderStatus.Short;
                                _Observer.Observe(new Observation(ObservationType.ScanResult, nextResult, _currentStatus));
                            }
                        }

                        if (_currentStatus == ProfitChartBotOrderStatus.Long)
                        {
                            if (Decision.ShortPredict > Decision.LongPredict &&
                                Decision.ShortPredict > _ModelParameters.DecisionBoundary &&
                                _useSmartStop)
                            {
                                _clickHelper.SendOpenCloseAllPositionsClick();
                                ProfitChartScannerLogging.Debug("(Order) Stop for Long Position:Click Sent...");
                                _longStop = null;
                                _longGain = null;
                                _currentStatus = ProfitChartBotOrderStatus.Liquid;
                                _Observer.Observe(new Observation(ObservationType.ScanResult, nextResult, _currentStatus));
                            }
                        }

                        if (_currentStatus == ProfitChartBotOrderStatus.Short)
                        {
                            if (Decision.LongPredict > Decision.ShortPredict &&
                                Decision.LongPredict > _ModelParameters.DecisionBoundary &&
                                _useSmartStop)
                            {
                                _clickHelper.SendOpenCloseAllPositionsClick();
                                ProfitChartScannerLogging.Debug("(Order) Stop for Short Position:Click Sent...");
                                _shortStop = null;
                                _shortGain = null;
                                _currentStatus = ProfitChartBotOrderStatus.Liquid;
                                _Observer.Observe(new Observation(ObservationType.ScanResult, nextResult, _currentStatus));
                            }
                        }
                    }
                    _lastResult = nextResult;
                }
            }

        }

    }
}
