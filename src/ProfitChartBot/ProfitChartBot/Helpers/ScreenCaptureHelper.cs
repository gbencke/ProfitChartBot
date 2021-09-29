using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProfitChartBot.BO;
using System.Drawing;
using System.Drawing.Imaging;
using ProfitChartBot.Enums;

namespace ProfitChartBot.Helpers
{
    public static class ScreenCaptureHelper
    {
        public static ComandoIndicador.Comando getIndicatorValue(ProfitChartBotConfiguration _configuration)
        {
            Rectangle rect = new Rectangle(
                _configuration.IndicadorPosicaoX.Value,
                _configuration.IndicadorPosicaoY.Value,
                _configuration.IndicadorLargura.Value,
                _configuration.IndicadorAltura.Value);

            var PosicaoInternaX = _configuration.IndicadorLargura.Value / 2;
            var PosicaoInternaY = _configuration.IndicadorAltura.Value / 2;

            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            Color pixel = bmp.GetPixel(PosicaoInternaX, PosicaoInternaY);
            if (pixel.R > 180 && pixel.G > 180 && pixel.B < 180)
            {
                return ComandoIndicador.Comando.Zerar;
            }
            if (pixel.R == 204 && pixel.G == 48 && pixel.B == 48)
            {
                return ComandoIndicador.Comando.Vender;
            }
            if (pixel.R == 17 && pixel.G == 152 && pixel.B == 80)
            {
                return ComandoIndicador.Comando.Comprar;
            }

            return ComandoIndicador.Comando.Neutro;
        }
    }
}
