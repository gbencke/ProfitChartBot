using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBotScanner
{
    public class Observation
    {

        private ObservationType _Type;
        private string _Message;
        private ProfitChartScanResult _ScanResult;

        public ProfitChartScanResult Result
        {
            get
            {
                return _ScanResult;
            }
        }

        public ObservationType Type
        {
            get
            {
                return _Type;
            }
        }

        public String Message
        {
            get
            {
                return _Message;
            }
        }

        public Observation(ObservationType type , string Message) 
        {
            _Type = type;
            _Message = Message;
        }

        public Observation(ObservationType type, ProfitChartScanResult ScanResult)
        {
            _Type = type;
            _Message = Message;
            _ScanResult = ScanResult;
        }

    }
}
