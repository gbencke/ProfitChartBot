using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBotScanner
{
    public enum ProfitChartBotScannerStatus
    {
        NonInitialized = 0,
        RequestingParameters = 1,
        ParametersReceived = 2,
        ParametersError = 3,
        Running = 4
    }
}
