using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Repository.Hierarchy;
using log4net.Core;
using log4net.Appender;
using log4net.Layout;

namespace ProfitChartBotScanner
{
    public static class ProfitChartScannerLogging
    {
        private static ILog _log;
        public static void InitializeLogger(string LogFile)
        {
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = "%date [%thread] %-5level %logger - %message%newline";
            patternLayout.ActivateOptions();

            RollingFileAppender roller = new RollingFileAppender();
            roller.AppendToFile = false;
            roller.File = LogFile;
            roller.Layout = patternLayout;
            roller.MaxSizeRollBackups = 5;
            roller.MaximumFileSize = "1GB";
            roller.RollingStyle = RollingFileAppender.RollingMode.Size;
            roller.StaticLogFileName = true;
            roller.ActivateOptions();
            hierarchy.Root.AddAppender(roller);

            hierarchy.Root.Level = Level.Debug;
            hierarchy.Configured = true;

            _log = LogManager.GetLogger("root");
        }

        public static void Info(string toLog)
        {
            _log.Info(toLog);
        }
        public static void Debug(string toLog)
        {
            _log.Debug(toLog);
        }
        public static void Warn(string toLog)
        {
            _log.Warn(toLog);
        }
        public static void Error(string toLog)
        {
            _log.Error(toLog);
        }
        public static void Fatal(string toLog)
        {
            _log.Fatal(toLog);
        }

        public static void LogResult(ProfitChartScanResult result)
        {
            var str = String.Format("Time({0}), Date({1}), High({2}), Low({3}), LastClose({4}), LastHigh({5}), LastLow({6}), LastOpen({7}), LastVolume({8})",
                result.ProfitChartTime.Value.ToString(),
                result.ProfitChartDate.Value.ToString(),
                result.ProfitChartHigh.Value.ToString(),
                result.ProfitChartLow.Value.ToString(),
                result.ProfitChartLastClose.Value.ToString(),
                result.ProfitChartLastHigh.Value.ToString(),
                result.ProfitChartLastLow.Value.ToString(),
                result.ProfitChartLastOpen.Value.ToString(),
                result.ProfitChartLastVolume.Value.ToString());

            _log.Debug(str);
        }
    }
}
