using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBotScanner
{
    public class ProfitChartScanResult
    {
        private string _Exchange = null;
        private string _Asset = null;
        private string _TimeFrame = null;
        private int? _ProfitChartTime = null;
        private int? _ProfitChartRealTime = null;
        private int? _ProfitChartDate = null;
        private int? _ProfitChartRealDate = null;
        private double? _ProfitChartHigh = null;
        private double? _ProfitChartLow = null;
        private double? _ProfitChartLastClose = null;
        private double? _ProfitChartLastHigh = null;
        private double? _ProfitChartLastLow = null;
        private double? _ProfitChartLastOpen = null;
        private double? _ProfitChartLastVolume = null;
        private double? _ShortPredicted = null;
        private double? _LongPredicted = null;
        private double? _DecisionBoundary = null;
        private ProfitChartBotOrderStatus _OrderStatus = ProfitChartBotOrderStatus.Liquid;
        private DateTime _ScanResultTime = DateTime.Now;
        public string Exchange
        {
            get
            {
                return _Exchange;
            }
            set
            {
                _Exchange = value;
            }
        }
        public string Asset
        {
            get
            {
                return _Asset;
            }
            set
            {
                _Asset = value;
            }
        }
        public string TimeFrame
        {
            get
            {
                return _TimeFrame;
            }
            set
            {
                _TimeFrame = value;
            }
        }

        public ProfitChartBotOrderStatus ProfitChartBotCurrentOrderStatus
        {
            get
            {
                return _OrderStatus;
            }
            set
            {
                _OrderStatus = value;
            }
        }
        public double? ShortPredicted
        {
            get
            {
                return _ShortPredicted;
            }
            set
            {
                _ShortPredicted = value;
                _ScanResultTime = DateTime.Now;
            }
        }
        public double? LongPredicted
        {
            get
            {
                return _LongPredicted;
            }
            set
            {
                _LongPredicted = value;
                _ScanResultTime = DateTime.Now;
            }
        }

        public double? DecisionBoundary
        {
            get
            {
                return _DecisionBoundary;
            }
            set
            {
                _DecisionBoundary = value;
            }
        }

        public int? ProfitChartTime
        {
            get
            {
                return _ProfitChartTime;
            }
        }
        public int? ProfitChartRealTime
        {
            get
            {
                return _ProfitChartRealTime;
            }
        }

        public int? ProfitChartDate
        {
            get
            {
                return _ProfitChartDate;
            }
        }
        public int? ProfitChartRealDate
        {
            get
            {
                return _ProfitChartRealDate;
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
        public DateTime ScanResultTime
        {
            get
            {
                return _ScanResultTime;
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

        public ProfitChartScanResult(double decisionBoundary, string exchange, string asset, string TimeFrame, string ResultFromTesseract)
        {
            var tokens = ResultFromTesseract.ToUpper().Split('\n');

            _Exchange = exchange;
            _Asset = asset;
            _TimeFrame = TimeFrame;
            _DecisionBoundary = decisionBoundary;

            foreach (var currentToken in tokens)
            {
                var processedToken = currentToken.Trim();
                var fullToken = processedToken;
                processedToken = CleanString(processedToken);
                processedToken = processedToken.Trim();
                processedToken = processedToken.Replace(",", ".");
                if (fullToken.StartsWith("ProfitChartBotTime".ToUpper()))
                {
                    processedToken = processedToken.Replace(".00", "");
                    if(processedToken.Length == 6)
                    {
                        processedToken = processedToken.Substring(0, 4);
                    }
                    if (String.IsNullOrEmpty(processedToken))
                    {
                        return;
                    }
                    _ProfitChartTime = Convert.ToInt32(processedToken);

                    var currentDateTime = DateTime.Now.ToString("yyyy-MM-dd") + 
                        "T" + 
                        (_ProfitChartTime.Value / 100).ToString("00") + 
                        ":" + 
                        (_ProfitChartTime.Value % 100).ToString("00");

                    var correctedTime = DateTime.Parse(currentDateTime).Subtract(TimeSpan.FromMinutes(5));

                    _ProfitChartRealTime = correctedTime.Hour * 100 + correctedTime.Minute;

                }
                if (fullToken.StartsWith("ProfitChartBotDate".ToUpper()))
                {
                    processedToken = processedToken.Replace(".00", "");
                    _ProfitChartDate = Convert.ToInt32(processedToken);

                    _ProfitChartRealDate = ((_ProfitChartDate.Value - 1000000) + 20000000);
                }
                if (fullToken.StartsWith("ProfitChartBotHigh".ToUpper()))
                {
                    if(processedToken.Length == 6)
                    {
                        _ProfitChartHigh = Convert.ToDouble(processedToken) / 100;
                    }
                    else
                    {
                        _ProfitChartHigh = Convert.ToDouble(processedToken);
                    }
                }
                if (fullToken.StartsWith("ProfitChartBotLow".ToUpper()))
                {
                    _ProfitChartLow = Convert.ToDouble(processedToken);
                }
                if (fullToken.StartsWith("ProfitChartBotLastClose".ToUpper()))
                {
                    _ProfitChartLastClose = Convert.ToDouble(processedToken);
                }
                if (fullToken.StartsWith("ProfitChartBotLastHigh".ToUpper()))
                {
                    if(processedToken.Length == 6)
                    {
                        _ProfitChartLastHigh = Convert.ToDouble(processedToken) / 100;
                    }
                    else
                    {
                        _ProfitChartLastHigh = Convert.ToDouble(processedToken);
                    }
                }
                if (fullToken.StartsWith("ProfitChartBotLastLow".ToUpper()) || fullToken.ToUpper().Contains("LastLow".ToUpper()))
                {
                    _ProfitChartLastLow = Convert.ToDouble(processedToken);
                }
                if (fullToken.StartsWith("ProfitChartBotLastOpen".ToUpper()) || fullToken.ToUpper().Contains("LastOpen".ToUpper()))
                {
                    _ProfitChartLastOpen = Convert.ToDouble(processedToken);
                }
                if (fullToken.StartsWith("ProfitChartBotLastVolume".ToUpper()))
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
        public override bool Equals(object obj)
        {
            if (!(obj is ProfitChartScanResult))
            {
                return false;
            }

            var b = (ProfitChartScanResult)obj;

            return this.ProfitChartDate.Value == b.ProfitChartDate.Value &&
                this.ProfitChartTime.Value == b.ProfitChartTime.Value &&
                this.ProfitChartHigh.Value == b.ProfitChartHigh.Value &&
                this.ProfitChartLow.Value == b.ProfitChartLow.Value &&
                this.ProfitChartLastClose.Value == b.ProfitChartLastClose.Value &&
                this.ProfitChartLastHigh.Value == b.ProfitChartLastHigh.Value &&
                this.ProfitChartLastLow.Value == b.ProfitChartLastLow.Value &&
                this.ProfitChartLastOpen.Value == b.ProfitChartLastOpen.Value &&
                this.ProfitChartLastVolume.Value == b.ProfitChartLastVolume.Value;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
