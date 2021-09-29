using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        public int Interval = 500;

        [JsonIgnore]
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

        [JsonIgnore]
        public bool IsVendaConfigurado
        {
            get
            {
                return 
                    VendaMercadoMiraPosicaoX.HasValue &&
                    VendaMercadoMiraPosicaoY.HasValue &&
                    VendaMercadoPosicaoX.HasValue &&
                    VendaMercadoPosicaoY.HasValue &&
                    VendaMercadoLargura.HasValue &&
                    VendaMercadoAltura.HasValue;
            }
        }

        public int? IndicadorMiraPosicaoX;
        public int? IndicadorMiraPosicaoY;
        public int? IndicadorPosicaoX;
        public int? IndicadorPosicaoY;
        public int? IndicadorLargura;
        public int? IndicadorAltura;

        [JsonIgnore]
        public bool IsIndicadorConfigurado
        {
            get
            {
                return 
                    IndicadorMiraPosicaoX.HasValue &&
                    IndicadorMiraPosicaoY.HasValue &&
                    IndicadorPosicaoX.HasValue &&
                    IndicadorPosicaoY.HasValue &&
                    IndicadorLargura.HasValue &&
                    IndicadorAltura.HasValue;
            }
        }

        public int? ZerarMiraPosicaoX;
        public int? ZerarMiraPosicaoY;
        public int? ZerarPosicaoX;
        public int? ZerarPosicaoY;
        public int? ZerarLargura;
        public int? ZerarAltura;
        [JsonIgnore]
        public bool IsZerarConfigurado
        {
            get
            {
                return 
                    ZerarMiraPosicaoX.HasValue &&
                    ZerarMiraPosicaoY.HasValue &&
                    ZerarPosicaoX.HasValue &&
                    ZerarPosicaoY.HasValue &&
                    ZerarLargura.HasValue &&
                    ZerarAltura.HasValue;
            }
        }

        public int? ValorMiraPosicaoX;
        public int? ValorMiraPosicaoY;
        public int? ValorPosicaoX;
        public int? ValorPosicaoY;
        public int? ValorLargura;
        public int? ValorAltura;

        [JsonIgnore]
        public bool IsValorConfigurado
        {
            get
            {
                return 
                    ValorMiraPosicaoX.HasValue &&
                    ValorMiraPosicaoY.HasValue &&
                    ValorPosicaoX.HasValue &&
                    ValorPosicaoY.HasValue &&
                    ValorLargura.HasValue &&
                    ValorAltura.HasValue;
            }
        }

        public int? ContratosAbertosMiraPosicaoX;
        public int? ContratosAbertosMiraPosicaoY;
        public int? ContratosAbertosPosicaoX;
        public int? ContratosAbertosPosicaoY;
        public int? ContratosAbertosLargura;
        public int? ContratosAbertosAltura;

        [JsonIgnore]
        public bool IsContratosConfigurado
        {
            get
            {
                return 
                    ContratosAbertosMiraPosicaoX.HasValue &&
                    ContratosAbertosMiraPosicaoY.HasValue &&
                    ContratosAbertosPosicaoX.HasValue &&
                    ContratosAbertosPosicaoY.HasValue &&
                    ContratosAbertosLargura.HasValue &&
                    ContratosAbertosAltura.HasValue;
            }
        }

        public bool IsConfigurado
        {
            get
            {
                return IsCompraConfigurado &&
                    IsContratosConfigurado &&
                    IsIndicadorConfigurado &&
                    IsValorConfigurado &&
                    IsVendaConfigurado &&
                    IsZerarConfigurado;
            }
        }

        public Point PointForComprar()
        {
            return new Point(CompraMercadoMiraPosicaoX.Value, CompraMercadoMiraPosicaoY.Value);
        }
        public Point PointForVender()
        {
            return new Point(VendaMercadoMiraPosicaoX.Value, VendaMercadoMiraPosicaoY.Value);
        }

        public Point PointForZerar()
        {
            return new Point(ZerarMiraPosicaoX.Value, ZerarMiraPosicaoY.Value);
        }

    }
}
