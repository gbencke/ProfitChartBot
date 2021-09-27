using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfitChartBot.BO;

namespace ProfitChartBot.Services
{
    interface IConfigurationService
    {
        void saveConfiguration(ProfitChartBotConfiguration _toSave);

        ProfitChartBotConfiguration getConfiguration();
    }
}
