using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProfitChartBot.Helpers
{
    public static class ConfigurationHelper
    {
        public static string getCurrentConfigurationFile()
        {
            var process = Process.GetCurrentProcess(); // Or whatever method you are using
            string fullPath = process.MainModule.FileName;

            var PathComponents = fullPath.Split('\\');
            var PathLength = PathComponents.Length;
            PathComponents[PathLength - 1] = "configuration.json";

            return String.Join("\\", PathComponents);
        }
    }
}
