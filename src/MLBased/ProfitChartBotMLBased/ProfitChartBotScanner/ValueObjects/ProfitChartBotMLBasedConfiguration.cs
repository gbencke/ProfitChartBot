using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProfitChartBotScanner
{
    public class ProfitChartBotMLBasedConfiguration
    {
        private ScreenRectangle _IndicatorsRegion = null;
        private ScreenPoint _StartLongPosition = null;
        private ScreenPoint _StartShortPosition = null;
        private ScreenPoint _ClosePositions = null;
        private String _TesseractExecutable = null;
        private String _TessDataLocation = null;
        private String _GETParametersURL = null;
        private String _POSTQuoteURL = null;
        private String _GETPredictionURL = null;
        private String _TextLogDir = null;
        private String _ImageLogDir = null;
        private int? _IntervalScanning = null;

        [JsonProperty("indicators_region")]
        public ScreenRectangle IndicatorsRegion
        {
            get
            {
                return _IndicatorsRegion;
            }
            set
            {
                _IndicatorsRegion = value;
            }
        }

        [JsonProperty("start_long_position")]
        public ScreenPoint StartLongPosition
        {
            get
            {
                return _StartLongPosition;
            }
            set
            {
                _StartLongPosition = value;
            }
        }
        [JsonProperty("start_short_position")]
        public ScreenPoint StartShortPosition
        {
            get
            {
                return _StartShortPosition;
            }
            set
            {
                _StartShortPosition = value;
            }
        }
        [JsonProperty("close_positions")]
        public ScreenPoint ClosePositions
        {
            get
            {
                return _ClosePositions;
            }
            set
            {
                _ClosePositions = value;
            }
        }

        [JsonProperty("tesseract_executable")]
        public String TesseractExecutable
        {
            get
            {
                return _TesseractExecutable;
            }

            set
            {
                _TesseractExecutable = value;
            }
        }

        [JsonProperty("tessdata_location")]
        public String TessDataLocation
        {
            get
            {
                return _TessDataLocation;
            }
            set
            {
                _TessDataLocation = value;
            }
        }

        [JsonProperty("get_parameters_url")]
        public String GETParametersURL
        {
            get
            {
                return _GETParametersURL;
            }
            set
            {
                _GETParametersURL = value;
            }
        }

        [JsonProperty("post_quote_url")]
        public String POSTQuoteURL
        {
            get
            {
                return _POSTQuoteURL;
            }
            set
            {
                _POSTQuoteURL = value;
            }
        }

        [JsonProperty("get_prediction_url")]
        public String GETPredictionURL
        {
            get
            {
                return _GETPredictionURL;
            }
            set
            {
                _GETPredictionURL = value;
            }
        }

        [JsonProperty("text_log_dir")]
        public String TextLogDir
        {
            get
            {
                return _TextLogDir;
            }
            set
            {
                _TextLogDir = value;
            }
        }
        [JsonProperty("image_log_dir")]
        public string ImageLogDir
        {
            get
            {
                return _ImageLogDir;
            }
            set
            {
                _ImageLogDir = value;
            }
        }
        [JsonProperty("interval_scanning")]
        public int? IntervalScanning
        {
            get
            {
                return _IntervalScanning;
            }
            set
            {
                _IntervalScanning = value;
            }
        }

        public bool HasIndicatorsRegion()
        {
            return _IndicatorsRegion != null;
        }

        public bool IsDataComplete()
        {
            return _IndicatorsRegion != null &&
            _StartLongPosition != null &&
            _StartShortPosition != null &&
            _ClosePositions != null &&
            _TesseractExecutable != null &&
            _TessDataLocation != null &&
            _GETParametersURL != null &&
            _POSTQuoteURL != null &&
            _GETPredictionURL != null &&
            _TextLogDir != null &&
            _ImageLogDir != null && 
            _IntervalScanning.HasValue;
        }
    }
}
