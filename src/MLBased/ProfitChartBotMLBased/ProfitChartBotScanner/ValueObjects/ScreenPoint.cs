using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProfitChartBotScanner
{
    public class ScreenPoint
    {
        private int _X;
        private int _Y;

        [JsonProperty("x")]
        public int X
        {
            get
            {
                return _X;
            }
        }
        [JsonProperty("y")]
        public int Y
        {
            get
            {
                return _Y;
            }
        }

        public ScreenPoint(int X, int Y)
        {
            _X = X;
            _Y = Y;
        }
    }
}
