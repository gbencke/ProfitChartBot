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

    }
}
