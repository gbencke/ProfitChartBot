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

        public void Initialize(ProfitChartBotMLBasedConfiguration configuration, IObserverProfitChartBotScanner observer)
        {
            if(_ProfitChartBotState != ProfitChartBotScannerStatus.NonInitialized)
            {
                throw new ProfitChartScannerInitializedException("Initialization has already been tried in this instance...");
            }

            _Observer = observer;

            var ReceiveParametersThread = new Thread(() =>
            {
                var URL = configuration.GETParametersURL;

                _Observer.Observe(new Observation(ObservationType.ReadingParameters, "Lendo Parametros do Modelo do Servidor..."));
                _ProfitChartBotState = ProfitChartBotScannerStatus.RequestingParameters;

                try
                {
                    _ModelParameters = HTTPHelper.GetParameters(URL, 30000);
                }catch(Exception ex)
                {
                    _Observer.Observe(new Observation(ObservationType.ErrorInReadingParameters, "Erro na Leitura dos Parametros:" + ex.Message));
                    _ProfitChartBotState = ProfitChartBotScannerStatus.ParametersError;
                }

                _Observer.Observe(new Observation(ObservationType.ParametersRead, "Parametros do Modelo foram lidos do Servidor..."));
                _ProfitChartBotState = ProfitChartBotScannerStatus.ParametersReceived;
            });

            ReceiveParametersThread.Start();
        }
    }
}
