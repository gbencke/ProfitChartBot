using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBotScanner
{
    public class ProfitChartBotMLBasedConfiguration
    {
        private ScreenRectangle _IndicatorsRegion = null;
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

        public ScreenPoint StartLongPosition { get; set; }
        public ScreenPoint StartShortPosition { get; set; }
        public ScreenPoint ClosePositions { get; set; }
        public String TesseractExecutable { get; set; }
        public String TesseractLocation { get; set; }
        public String GETParametersURL { get; set; }
        public String POSTQuoteURL { get; set; }
        public String GETPredictionURL { get; set; }

        public bool HasIndicatorsRegion()
        {
            return _IndicatorsRegion != null;
        }
    }
}
