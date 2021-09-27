using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfitChartBot.Helpers;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProfitChartBot.BO;


namespace ProfitChartBot.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private string _configurationFile = ConfigurationHelper.getCurrentConfigurationFile();

        public ProfitChartBotConfiguration getConfiguration()
        {
            if (File.Exists(_configurationFile))
            {

                return JsonConvert.DeserializeObject<ProfitChartBotConfiguration>(File.ReadAllText(_configurationFile));
            }

            return new ProfitChartBotConfiguration();
        }

        void IConfigurationService.saveConfiguration(ProfitChartBotConfiguration _toSave)
        {
            File.WriteAllText(_configurationFile, JsonConvert.SerializeObject(_toSave));
        }
    }
}
