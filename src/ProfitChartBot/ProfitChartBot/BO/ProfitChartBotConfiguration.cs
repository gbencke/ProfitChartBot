using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitChartBot.BO
{
    public class ProfitChartBotConfiguration
    {
        public int? CompraMercadoMiraPosicaoX;
        public int? CompraMercadoMiraPosicaoY;
        public int? CompraMercadoPosicaoX;
        public int? CompraMercadoPosicaoY;
        public int? CompraMercadoLargura;
        public int? CompraMercadoAltura;
        public bool IsCompraConfigurado
        {
            get
            {
                return 
                    CompraMercadoMiraPosicaoX.HasValue &&
                    CompraMercadoMiraPosicaoY.HasValue &&
                    CompraMercadoPosicaoX.HasValue &&
                    CompraMercadoPosicaoY.HasValue &&
                    CompraMercadoLargura.HasValue &&
                    CompraMercadoAltura.HasValue;
            }
        }

        public int? VendaMercadoMiraPosicaoX;
        public int? VendaMercadoMiraPosicaoY;
        public int? VendaMercadoPosicaoX;
        public int? VendaMercadoPosicaoY;
        public int? VendaMercadoLargura;
        public int? VendaMercadoAltura;

        public int? IndicadorMiraPosicaoX;
        public int? IndicadorMiraPosicaoY;
        public int? IndicadorPosicaoX;
        public int? IndicadorPosicaoY;
        public int? IndicadorLargura;
        public int? IndicadorAltura;

        public int? ZerarMiraPosicaoX;
        public int? ZerarMiraPosicaoY;
        public int? ZerarPosicaoX;
        public int? ZerarPosicaoY;
        public int? ZerarLargura;
        public int? ZerarAltura;

        public int? ValorMiraPosicaoX;
        public int? ValorMiraPosicaoY;
        public int? ValorPosicaoX;
        public int? ValorPosicaoY;
        public int? ValorLargura;
        public int? ValorAltura;

        public int? ContratosAbertosMiraPosicaoX;
        public int? ContratosAbertosMiraPosicaoY;
        public int? ContratosAbertosPosicaoX;
        public int? ContratosAbertosPosicaoY;
        public int? ContratosAbertosLargura;
        public int? ContratosAbertosAltura;


    }
}
