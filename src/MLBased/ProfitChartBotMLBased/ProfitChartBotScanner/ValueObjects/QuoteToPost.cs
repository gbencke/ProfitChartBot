using Newtonsoft.Json;

namespace ProfitChartBotScanner
{
    public class QuoteToPost
    {
        private string _Exchange;
        private string _Asset;
        private string _TimeFrame;
        private string _Date;
        private string _Time;
        private double _Open;
        private double _High;
        private double _Low;
        private double _Close;
        private double _Business;
        private double _Volume;

        [JsonIgnore]
        public string Exchange
        {
            get
            {
                return _Exchange;
            }
        }
        [JsonIgnore]
        public string Asset
        {
            get
            {
                return _Asset;
            }
        }
        [JsonIgnore]
        public string TimeFrame
        {
            get
            {
                return _TimeFrame;
            }
        }

        [JsonProperty("date")]
        public string Date
        {
            get
            {
                return _Date;
            }
        }

        [JsonProperty("time")]
        public string Time
        {
            get
            {
                return _Time;
            }
        }
        [JsonProperty("open")]
        public double Open
        {
            get
            {
                return _Open;
            }
        }
        [JsonProperty("high")]
        public double High
        {
            get
            {
                return _High;
            }
        }
        [JsonProperty("low")]
        public double Low
        {
            get
            {
                return _Low;
            }
        }
        [JsonProperty("close")]
        public double Close
        {
            get
            {
                return _Close;
            }
        }
        [JsonProperty("business")]
        public double Business
        {
            get
            {
                return _Business;
            }
        }
        [JsonProperty("volume")]
        public double Volume
        {
            get
            {
                return _Volume;
            }
        }

        public QuoteToPost(ProfitChartScanResult ScanResult)
        {
            this._Exchange = ScanResult.Exchange;
            this._Asset = ScanResult.Asset;
            this._TimeFrame = ScanResult.TimeFrame;
            this._Date = ((ScanResult.ProfitChartDate.Value - 1000000) + 20000000).ToString();
            this._Time = ScanResult.ProfitChartRealTime.Value.ToString("0000");
            this._Open = ScanResult.ProfitChartLastOpen.Value;
            this._High = ScanResult.ProfitChartLastHigh.Value;
            this._Low = ScanResult.ProfitChartLastLow.Value;
            this._Close = ScanResult.ProfitChartLastClose.Value;
            this._Business = 0;
            this._Volume = ScanResult.ProfitChartLastVolume.Value;
        }
    }
}
