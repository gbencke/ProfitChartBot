using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBotScanner
{
    public enum ObservationType
    {
        ReadingParameters = 0,
        ErrorInReadingParameters = 1,
        ParametersRead = 2,
        RunningScanner = 3,
        ScanResult = 4
    }
}
