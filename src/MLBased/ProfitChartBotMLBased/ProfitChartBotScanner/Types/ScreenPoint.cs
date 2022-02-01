using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBotScanner
{
    public class ScreenPoint
    {
        private int _X;
        private int _Y;

        public int X { 
            get {
                return _X;
            } 
        }
        public int Y { 
            get {
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
