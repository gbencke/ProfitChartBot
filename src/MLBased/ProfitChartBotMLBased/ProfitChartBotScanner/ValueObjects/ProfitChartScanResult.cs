using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBotScanner
{
    public class ProfitChartScanResult
    {
        private int? _ProfitChartTime = null;
        private int? _ProfitChartDate = null;
        private double? _ProfitChartHigh = null;
        private double? _ProfitChartLow = null;
        private double? _ProfitChartLastClose = null;
        private double? _ProfitChartLastHigh = null;
        private double? _ProfitChartLastLow = null;
        private double? _ProfitChartLastOpen = null;
        private double? _ProfitChartLastVolume = null;

        public int? ProfitChartTime
        {
            get
            {
                return _ProfitChartTime;
            }
        }
        public int? ProfitChartDate
        {
            get
            {
                return _ProfitChartDate;
            }
        }
        public double? ProfitChartHigh
        {
            get
            {
                return _ProfitChartHigh;
            }
        }
        public double? ProfitChartLow
        {
            get
            {
                return _ProfitChartLow;
            }
        }

        public double? ProfitChartLastClose
        {
            get
            {
                return _ProfitChartLastClose;
            }

        }
        public double? ProfitChartLastHigh
        {
            get
            {
                return _ProfitChartLastHigh;
            }
        }
        public double? ProfitChartLastLow
        {
            get
            {
                return _ProfitChartLastLow;
            }
        }
        public double? ProfitChartLastOpen
        {
            get
            {
                return _ProfitChartLastOpen;
            }
        }
        public double? ProfitChartLastVolume
        {
            get
            {
                return _ProfitChartLastVolume;
            }
        }

        private string CleanString(string toClean)
        {
            var ret = "";

            foreach (var currentChar in toClean)
            {

                if ((((byte)currentChar) < 48 || ((byte)currentChar > 57)) && currentChar != ',')
                {
                    continue;
                }

                ret += currentChar;
            }

            return ret;
        }

        public ProfitChartScanResult(string ResultFromTesseract)
        {
            var tokens = ResultFromTesseract.Split('\n');

            foreach (var currentToken in tokens)
            {
                var processedToken = currentToken.Trim();
                var fullToken = processedToken;
                processedToken = CleanString(processedToken);
                processedToken = processedToken.Trim();
                processedToken = processedToken.Replace(",", ".");
                if (fullToken.StartsWith("ProfitChartBotTime"))
                {
                    processedToken = processedToken.Replace(".00", "");
                    _ProfitChartTime = Convert.ToInt32(processedToken);
                }
                if (fullToken.StartsWith("ProfitChartBotDate"))
                {
                    processedToken = processedToken.Replace(".00", "");
                    _ProfitChartDate = Convert.ToInt32(processedToken);
                }
                if (fullToken.StartsWith("ProfitChartBotHigh"))
                {
                    _ProfitChartHigh = Convert.ToDouble(processedToken);
                }
                if (fullToken.StartsWith("ProfitChartBotLow"))
                {
                    _ProfitChartLow = Convert.ToDouble(processedToken);
                }
                if (fullToken.StartsWith("ProfitChartBotLastClose"))
                {
                    _ProfitChartLastClose = Convert.ToDouble(processedToken);
                }
                if (fullToken.StartsWith("ProfitChartBotLastHigh"))
                {
                    _ProfitChartLastHigh = Convert.ToDouble(processedToken);
                }
                if (fullToken.StartsWith("ProfitChartBotLastLow") || fullToken.ToUpper().Contains("LastLow".ToUpper()))
                {
                    _ProfitChartLastLow = Convert.ToDouble(processedToken);
                }
                if (fullToken.StartsWith("ProfitChartBotLastOpen") || fullToken.ToUpper().Contains("LastOpen".ToUpper()))
                {
                    _ProfitChartLastOpen = Convert.ToDouble(processedToken);
                }
                if (fullToken.StartsWith("ProfitChartBotLastVolume"))
                {
                    _ProfitChartLastVolume = Convert.ToDouble(processedToken);
                }
            }
        }

        public bool IsDataOk
        {
            get
            {
                return _ProfitChartDate.HasValue &&
                    _ProfitChartTime.HasValue &&
                    _ProfitChartHigh.HasValue &&
                    _ProfitChartLow.HasValue &&
                    _ProfitChartLastClose.HasValue &&
                    _ProfitChartLastHigh.HasValue &&
                    _ProfitChartLastLow.HasValue &&
                    _ProfitChartLastOpen.HasValue &&
                    _ProfitChartLastVolume.HasValue;
            }
        }
        public static bool operator ==(ProfitChartScanResult a, ProfitChartScanResult b)
        {
            if (a is null || b is null)
            {
                return false;
            }

            if (!(a.IsDataOk && b.IsDataOk))
            {
                return false;
            }

            if (a.ProfitChartDate.Value == b.ProfitChartDate.Value &&
                a.ProfitChartTime.Value == b.ProfitChartTime.Value &&
                a.ProfitChartHigh.Value == b.ProfitChartHigh.Value &&
                a.ProfitChartLow.Value == b.ProfitChartLow.Value &&
                a.ProfitChartLastClose.Value == b.ProfitChartLastClose.Value &&
                a.ProfitChartLastHigh.Value == b.ProfitChartLastHigh.Value &&
                a.ProfitChartLastLow.Value == b.ProfitChartLastLow.Value &&
                a.ProfitChartLastOpen.Value == b.ProfitChartLastOpen.Value &&
                a.ProfitChartLastVolume.Value == b.ProfitChartLastVolume.Value)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(ProfitChartScanResult a, ProfitChartScanResult b)
        {
            if (a is null || b is null)
            {
                return true;
            }

            if (!(a.IsDataOk && b.IsDataOk))
            {
                return false;
            }

            if (!(a.ProfitChartDate.Value == b.ProfitChartDate.Value &&
                a.ProfitChartTime.Value == b.ProfitChartTime.Value &&
                a.ProfitChartHigh.Value == b.ProfitChartHigh.Value &&
                a.ProfitChartLow.Value == b.ProfitChartLow.Value &&
                a.ProfitChartLastClose.Value == b.ProfitChartLastClose.Value &&
                a.ProfitChartLastHigh.Value == b.ProfitChartLastHigh.Value &&
                a.ProfitChartLastLow.Value == b.ProfitChartLastLow.Value &&
                a.ProfitChartLastOpen.Value == b.ProfitChartLastOpen.Value &&
                a.ProfitChartLastVolume.Value == b.ProfitChartLastVolume.Value))
            {
                return true;
            }

            return false;

        }

    }
}
