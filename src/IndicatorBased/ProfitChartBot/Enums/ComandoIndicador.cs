using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBot.Enums
{
    public class ComandoIndicador
    {
        public  enum Comando
        {
            Neutro = -1,
            Comprar = 0,
            Vender = 1,
            Zerar = 2
        }
    }
}
