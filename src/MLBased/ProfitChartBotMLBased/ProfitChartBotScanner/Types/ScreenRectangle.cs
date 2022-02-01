using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBotScanner
{
    public class ScreenRectangle
    {
        public int _X;
        public int _Y;
        public int _Width;
        public int _Height;

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
        public int Width {  
            get {
                return _Width;
            } 
        }
        public int Height {  
            get {
                return _Height;
            } 
        }

        public ScreenRectangle(int X, int Y, int Width, int Height)
        {
            _X = X;
            _Y = Y;
            _Width = Width;
            _Height = Height;
        }
    }
}
