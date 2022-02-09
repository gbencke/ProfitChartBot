using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBotScanner
{
    public interface IObserverProfitChartBotScanner
    {
        void Observe(Observation Observed);
    }
}
