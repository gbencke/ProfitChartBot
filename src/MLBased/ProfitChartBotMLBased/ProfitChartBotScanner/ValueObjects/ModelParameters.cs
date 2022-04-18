using Newtonsoft.Json;

namespace ProfitChartBotScanner
{
    public class ModelParameters
    {
        public string _CurrentExchange;
        public int _MinimumTime;
        public int _MaximumTime;
        public int _MinimumDateDataFrame;
        public int _MinimumDateTrade;
        public int _MaxTrainDate;
        public int _MaxTradeDuration;
        public double _CurrentTarget;
        public double _CurrentStop;
        public string _CurrentAsset;
        public string _CurrentTimeFrame;
        public string _CurrentDailyFileCSV;
        public string _Current5MinFileCSV;
        public double _DecisionBoundary;
        public string _CurrentYColumnShort;
        public string _CurrentYColumnLong;
        public string[] _CurrentXColumns;

        [JsonProperty("CURRENT_EXCHANGE")]
        public string CurrentExchange
        {
            get
            {
                return _CurrentExchange;
            }
            set
            {
                _CurrentExchange = value;
            }
        }

        [JsonProperty("MINIMUM_TIME")]
        public int MinimumTime
        {
            get
            {
                return _MinimumTime;

            }
            set
            {
                _MinimumTime = value;
            }
        }

        [JsonProperty("MAXIMUM_TIME")]
        public int MaximumTime
        {
            get
            {
                return _MaximumTime;
            }
            set
            {
                _MaximumTime = value;
            }
        }

        [JsonProperty("MINIMUM_DATE_DATAFRAME")]
        public int MinimumDateDataFrame
        {
            get
            {
                return _MinimumDateDataFrame;
            }
            set
            {
                _MinimumDateDataFrame = value;
            }
        }

        [JsonProperty("MINIMUM_DATE_TRADE")]
        public int MinimumDateTrade
        {
            get
            {
                return _MinimumDateTrade;
            }
            set
            {
                _MinimumDateTrade = value;
            }
        }

        [JsonProperty("MAX_TRAIN_DATE")]
        public int MaxTrainDate
        {
            get
            {
                return _MaxTrainDate;
            }
            set
            {
                _MaxTrainDate = value;
            }
        }

        [JsonProperty("MAX_TRADE_DURATION")]
        public int MaxTradeDuration
        {
            get
            {
                return _MaxTradeDuration;
            }
            set
            {
                _MaxTradeDuration = value;
            }
        }

        [JsonProperty("CURRENT_TARGET")]
        public double CurrentTarget
        {
            get
            {
                return _CurrentTarget;
            }
            set
            {
                _CurrentTarget = value;
            }
        }

        [JsonProperty("CURRENT_STOP")]
        public double CurrentStop
        {
            get
            {
                return _CurrentStop;
            }
            set
            {
                _CurrentStop = value;
            }
        }

        [JsonProperty("CURRENT_ASSET")]
        public string CurrentAsset
        {
            get
            {
                return _CurrentAsset;
            }
            set
            {
                _CurrentAsset = value;
            }
        }

        [JsonProperty("CURRENT_TIMEFRAME")]
        public string CurrentTimeFrame
        {
            get
            {
                return _CurrentTimeFrame;
            }
            set
            {
                _CurrentTimeFrame = value;
            }

        }

        [JsonProperty("CURRENT_DAILY_FILE_CSV")]
        public string CurrentDailyFileCSV
        {
            get
            {
                return _CurrentDailyFileCSV;
            }
            set
            {
                _CurrentDailyFileCSV = value;
            }
        }

        [JsonProperty("CURRENT_5MIN_FILE_CSV")]
        public string Current5MinFileCSV
        {
            get
            {
                return _Current5MinFileCSV;
            }
            set
            {
                _Current5MinFileCSV = value;
            }
        }

        [JsonProperty("DECISION_BOUNDARY")]
        public double DecisionBoundary
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

        [JsonProperty("CURRENT_Y_COLUMN_SHORT")]
        public string CurrentYColumnShort
        {
            get
            {
                return _CurrentYColumnShort;
            }
            set
            {
                _CurrentYColumnShort = value;
            }

        }

        [JsonProperty("CURRENT_Y_COLUMN_LONG")]
        public string CurrentYColumnLong
        {
            get
            {
                return _CurrentYColumnLong;
            }
            set
            {
                _CurrentYColumnLong = value;
            }
        }

        [JsonProperty("CURRENT_X_COLUMNS")]
        public string[] CurrentXColumns
        {
            get
            {
                return _CurrentXColumns;
            }
            set
            {
                _CurrentXColumns = value;
            }
        }

    }
}
