using Newtonsoft.Json;

namespace ProfitChartBotScanner
{
    public class SignalPrediction
    {
        private double? _ShortPredict;
        private double? _LongPredict;


        [JsonProperty("short_predict")]
        public double? ShortPredict
        {
            get
            {
                return _ShortPredict;
            }
            set
            {
                _ShortPredict = value;
            }
        }
        [JsonProperty("long_predict")]
        public double? LongPredict
        {
            get
            {
                return _LongPredict;
            }
            set
            {
                _LongPredict = value;
            }
        }
    }
}
