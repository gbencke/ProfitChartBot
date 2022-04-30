using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBotScanner
{
    public interface IProfitChartBotScannerService
    {
        void Initialize(ProfitChartBotMLBasedConfiguration configuration, IObserverProfitChartBotScanner observer, bool useSmartStop);

        void StartExecution();

    }
}
