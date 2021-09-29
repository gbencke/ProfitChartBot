using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ProfitChartBot.BO;
using ProfitChartBot.Helpers;
using System.Drawing;
using System.Drawing.Imaging;
using ProfitChartBot.Enums;

namespace ProfitChartBot.Services.Implementation
{
    public class RobotService : IRobotService
    {

        private bool _ShouldStop = false;
        private ProfitChartBotConfiguration _configuration;
        private Thread _Thread;
        private ComandoIndicador.Comando _ultimoComandoExecutado = ComandoIndicador.Comando.Neutro;

        public RobotService(ProfitChartBotConfiguration configuration)
        {
            _configuration = configuration;
        }


        private void DoWork()
        {

            while (!_ShouldStop)
            {
                try
                {
                    Thread.Sleep(_configuration.Interval);

                    var comandoParaExecutar = ScreenCaptureHelper.getIndicatorValue(_configuration);
                    if (comandoParaExecutar == ComandoIndicador.Comando.Neutro)
                    {
                        _ultimoComandoExecutado = comandoParaExecutar;
                        continue;
                    }
                    if (comandoParaExecutar == _ultimoComandoExecutado)
                    {
                        continue;
                    }

                    if (comandoParaExecutar == ComandoIndicador.Comando.Comprar)
                    {
                        SendClickHelper.ClickOnPoint(_configuration.PointForComprar());
                    }

                    if (comandoParaExecutar == ComandoIndicador.Comando.Vender)
                    {
                        SendClickHelper.ClickOnPoint(_configuration.PointForVender());

                    }
                    if (comandoParaExecutar == ComandoIndicador.Comando.Zerar)
                    {
                        SendClickHelper.ClickOnPoint(_configuration.PointForZerar());

                    }

                    _ultimoComandoExecutado = comandoParaExecutar;

                }
                catch (Exception ex)
                {

                }
            }

        }
        void IRobotService.Start()
        {
            _Thread = new Thread(DoWork);
            _Thread.IsBackground = true;
            _Thread.Start();
        }

        void IRobotService.Stop()
        {
            _ShouldStop = true;
        }
    }
}
