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
        private ProfitChartBotScannerStatus _ProfitChartBotState = ProfitChartBotScannerStatus.NonInitialized;
        private IObserverProfitChartBotScanner _Observer;
        private ModelParameters _ModelParameters;
        private ProfitChartScanHelper _scanner;
        private ProfitChartBotMLBasedConfiguration _configuration;
        private bool _ShouldRun = false;

        public void Initialize(ProfitChartBotMLBasedConfiguration configuration, IObserverProfitChartBotScanner observer)
        {
            if (_ProfitChartBotState != ProfitChartBotScannerStatus.NonInitialized)
            {
                throw new ProfitChartScannerInitializedException("Initialization has already been tried in this instance...");
            }

            _Observer = observer;
            _configuration = configuration;

            var ReceiveParametersThread = new Thread(() =>
            {
                var URL = configuration.GETParametersURL;

                _Observer.Observe(new Observation(ObservationType.ReadingParameters, "Lendo Parametros do Modelo do Servidor..."));
                _ProfitChartBotState = ProfitChartBotScannerStatus.RequestingParameters;

                try
                {
                    _ModelParameters = HTTPHelper.GetParameters(URL, 30000);
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

        private int MinCaptureOffset = -10;
        private int MaxCaptureOffset = 10;
        private int CurrentOffset = 0;

        public void ExecuteScanning()
        {
            ProfitChartBotOrderStatus _currentStatus = ProfitChartBotOrderStatus.Liquid;
            ProfitChartScanResult _lastResult = null;

            _Observer.Observe(new Observation(ObservationType.RunningScanner, "Running the Scanning for ProfitChart"));
            _ProfitChartBotState = ProfitChartBotScannerStatus.Running;
            _scanner = new ProfitChartScanHelper(_configuration, _ModelParameters);

        

            while (_ShouldRun)
            {
                Thread.Sleep(_configuration.IntervalScanning.Value);

                ProfitChartScanResult nextResult = _scanner.GetNextScan(CurrentOffset);
                if(nextResult == null)
                {
                    ProfitChartScannerLogging.Debug(String.Format("Error in Scanning the Data..."));

                    for(int _currentOffset = MinCaptureOffset;_currentOffset <= MaxCaptureOffset; _currentOffset++)
                    {
                        CurrentOffset = _currentOffset;
                        nextResult = _scanner.GetNextScan(CurrentOffset);
                        if(nextResult != null)
                        {
                            ProfitChartScannerLogging.Debug(String.Format("Current Offset:{0}", CurrentOffset));
                            break; 
                        }
                    }

                    if(nextResult == null)
                    {
                        ProfitChartScannerLogging.Debug("Error in Scanning the Data...");
                        continue;
                    }

                }

                if (!(nextResult is null))
                {
                    ProfitChartScannerLogging.LogResult(nextResult);
                    _Observer.Observe(new Observation(ObservationType.ScanResult, nextResult));

                    if (!(_lastResult is null) && _lastResult.Equals(nextResult))
                    {
                        continue;
                    }

                    if(!(_lastResult is null) && _lastResult.ProfitChartTime == nextResult.ProfitChartTime)
                    {
                        continue;
                    }

                    ProfitChartScannerLogging.Debug("Posting:");
                    ProfitChartScannerLogging.LogResult(nextResult);

                    HTTPHelper.PostQuote(_configuration.POSTQuoteURL, new QuoteToPost(nextResult), 30000);

                    _lastResult = nextResult;
                }

            }

        }

        Thread _scannerExecutionThread;
        public void StartExecution()
        {
            _ShouldRun = true;
            _scannerExecutionThread = new Thread(ExecuteScanning);
            _scannerExecutionThread.Start();
        }
    }
}
