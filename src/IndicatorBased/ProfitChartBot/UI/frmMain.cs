using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfitChartBot.BO;
using ProfitChartBot.Services;
using ProfitChartBot.Services.Implementation;
using ProfitChartBot.UI;

namespace ProfitChartBot
{
    public partial class frmMain : Form
    {
        private IConfigurationService _configurationService = new ConfigurationService();
        private ProfitChartBotConfiguration _configuration;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _configuration = _configurationService.getConfiguration();
            RefreshControls();
        }
        private void btnLimparConfiguracao_Click(object sender, EventArgs e)
        {
            _configuration = _configurationService.clearConfiguration();
            RefreshControls();
        }

        private void SalvarConfiguracao()
        {
            _configurationService.saveConfiguration(_configuration);
            RefreshControls();
        }

        private void RefreshControls()
        {
            if (_configuration.IsConfigurado)
            {
                btnIniciar.Enabled = true;
            }
            if (_configuration.IsCompraConfigurado)
            {
                lblBotaoCompraMercado.ForeColor = Color.Black;
            }
            else
            {
                lblBotaoCompraMercado.ForeColor = Color.Red;
            }
            if (_configuration.IsContratosConfigurado)
            {
                lblNumeroDeContratos.ForeColor = Color.Black;
            }
            else
            {
                lblNumeroDeContratos.ForeColor = Color.Red;
            }
            if (_configuration.IsIndicadorConfigurado)
            {
                lblIndicadorParaTomarPosicao.ForeColor = Color.Black;
            }
            else
            {
                lblIndicadorParaTomarPosicao.ForeColor = Color.Red;
            }
            if (_configuration.IsVendaConfigurado)
            {
                lblBotaoVendaMercado.ForeColor = Color.Black;
            }
            else
            {
                lblBotaoVendaMercado.ForeColor = Color.Red;
            }
            if (_configuration.IsZerarConfigurado)
            {
                lblBotaoZerarPosicao.ForeColor = Color.Black;
            }
            else
            {
                lblBotaoZerarPosicao.ForeColor = Color.Red;
            }
            if (_configuration.IsValorConfigurado)
            {
                lblValorPosicaoAberta.ForeColor = Color.Black;
            }
            else
            {
                lblValorPosicaoAberta.ForeColor = Color.Red;
            }
        }


        private void btnCompraMercado_Click(object sender, EventArgs e)
        {
            var frm = new frmSelecionarRegiao(
                _configuration.CompraMercadoPosicaoX,
                _configuration.CompraMercadoPosicaoY,
                _configuration.CompraMercadoLargura,
                _configuration.CompraMercadoAltura,
                "Mire no Botao de Compra Mercado");

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _configuration.CompraMercadoMiraPosicaoX = frm.PosicaoMiraX;
                _configuration.CompraMercadoMiraPosicaoY = frm.PosicaoMiraY;
                _configuration.CompraMercadoPosicaoX = frm.PosicaoX;
                _configuration.CompraMercadoPosicaoY = frm.PosicaoY;
                _configuration.CompraMercadoLargura = frm.LarguraJanela;
                _configuration.CompraMercadoAltura = frm.AlturaJanela;
                SalvarConfiguracao();
            }
        }


        private void btnVendaMercado_Click(object sender, EventArgs e)
        {
            var frm = new frmSelecionarRegiao(
                _configuration.VendaMercadoPosicaoX,
                _configuration.VendaMercadoPosicaoY,
                _configuration.VendaMercadoLargura,
                _configuration.VendaMercadoAltura,
                "Mire no Botao de Venda Mercado");

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _configuration.VendaMercadoMiraPosicaoX = frm.PosicaoMiraX;
                _configuration.VendaMercadoMiraPosicaoY = frm.PosicaoMiraY;
                _configuration.VendaMercadoPosicaoX = frm.PosicaoX;
                _configuration.VendaMercadoPosicaoY = frm.PosicaoY;
                _configuration.VendaMercadoLargura = frm.LarguraJanela;
                _configuration.VendaMercadoAltura = frm.AlturaJanela;
                SalvarConfiguracao();
            }

        }

        private void btnTomarPosicao_Click(object sender, EventArgs e)
        {
            var frm = new frmSelecionarRegiao(
                _configuration.IndicadorPosicaoX,
                _configuration.IndicadorPosicaoY,
                _configuration.IndicadorLargura,
                _configuration.IndicadorAltura,
                "Mire no Indicador");

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _configuration.IndicadorMiraPosicaoX = frm.PosicaoMiraX;
                _configuration.IndicadorMiraPosicaoY = frm.PosicaoMiraY;
                _configuration.IndicadorPosicaoX = frm.PosicaoX;
                _configuration.IndicadorPosicaoY = frm.PosicaoY;
                _configuration.IndicadorLargura = frm.LarguraJanela;
                _configuration.IndicadorAltura = frm.AlturaJanela;
                SalvarConfiguracao();
            }

        }

        private void btnZerarMercado_Click(object sender, EventArgs e)
        {
            var frm = new frmSelecionarRegiao(
                _configuration.ZerarPosicaoX,
                _configuration.ZerarPosicaoY,
                _configuration.ZerarLargura,
                _configuration.ZerarAltura,
                "Mire no Indicador");

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _configuration.ZerarMiraPosicaoX = frm.PosicaoMiraX;
                _configuration.ZerarMiraPosicaoY = frm.PosicaoMiraY;
                _configuration.ZerarPosicaoX = frm.PosicaoX;
                _configuration.ZerarPosicaoY = frm.PosicaoY;
                _configuration.ZerarLargura = frm.LarguraJanela;
                _configuration.ZerarAltura = frm.AlturaJanela;
                SalvarConfiguracao();
            }

        }

        private void btnValorPosicaoAberta_Click(object sender, EventArgs e)
        {
            var frm = new frmSelecionarRegiao(
                _configuration.ValorPosicaoX,
                _configuration.ValorPosicaoY,
                _configuration.ValorLargura,
                _configuration.ValorAltura,
                "Mire em \"Res.do Dia\"");

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _configuration.ValorMiraPosicaoX = frm.PosicaoMiraX;
                _configuration.ValorMiraPosicaoY = frm.PosicaoMiraY;
                _configuration.ValorPosicaoX = frm.PosicaoX;
                _configuration.ValorPosicaoY = frm.PosicaoY;
                _configuration.ValorLargura = frm.LarguraJanela;
                _configuration.ValorAltura = frm.AlturaJanela;
                SalvarConfiguracao();
            }

        }

        private void btnNumeroContratosAbertos_Click(object sender, EventArgs e)
        {
            var frm = new frmSelecionarRegiao(
                _configuration.ContratosAbertosPosicaoX,
                _configuration.ContratosAbertosPosicaoY,
                _configuration.ContratosAbertosLargura,
                _configuration.ContratosAbertosAltura,
                "Mire em Resultado");

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _configuration.ContratosAbertosMiraPosicaoX = frm.PosicaoMiraX;
                _configuration.ContratosAbertosMiraPosicaoY = frm.PosicaoMiraY;
                _configuration.ContratosAbertosPosicaoX = frm.PosicaoX;
                _configuration.ContratosAbertosPosicaoY = frm.PosicaoY;
                _configuration.ContratosAbertosLargura = frm.LarguraJanela;
                _configuration.ContratosAbertosAltura = frm.AlturaJanela;
                SalvarConfiguracao();
            }

        }

        private IRobotService _robotService;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {
                btnIniciar.Text = "Parar";
                _robotService = new RobotService(_configuration);
                _robotService.Start();
            }
            else
            {
                btnIniciar.Text = "Iniciar";

            }

        }

        private void btnMostrarPosicoes_Click(object sender, EventArgs e)
        {
            if (_configuration.IsCompraConfigurado)
            {
                var mostrarCompra = new frmMostrarRegiao(
                    _configuration.CompraMercadoPosicaoX.Value,
                    _configuration.CompraMercadoPosicaoY.Value,
                    _configuration.CompraMercadoLargura.Value,
                    _configuration.CompraMercadoAltura.Value,
                    _configuration.CompraMercadoMiraPosicaoX.Value,
                    _configuration.CompraMercadoMiraPosicaoY.Value);

                mostrarCompra.ShowDialog();
            }

            if (_configuration.IsVendaConfigurado)
            {
                var mostrarVenda = new frmMostrarRegiao(
                    _configuration.VendaMercadoPosicaoX.Value,
                    _configuration.VendaMercadoPosicaoY.Value,
                    _configuration.VendaMercadoLargura.Value,
                    _configuration.VendaMercadoAltura.Value,
                    _configuration.VendaMercadoMiraPosicaoX.Value,
                    _configuration.VendaMercadoMiraPosicaoY.Value);

                mostrarVenda.ShowDialog();
            }

            if (_configuration.IsZerarConfigurado)
            {
                var mostrarZerar = new frmMostrarRegiao(
                    _configuration.ZerarPosicaoX.Value,
                    _configuration.ZerarPosicaoY.Value,
                    _configuration.ZerarLargura.Value,
                    _configuration.ZerarAltura.Value,
                    _configuration.ZerarMiraPosicaoX.Value,
                    _configuration.ZerarMiraPosicaoY.Value);

                mostrarZerar.ShowDialog();
            }

            if (_configuration.IsIndicadorConfigurado)
            {
                var mostrarIndicador = new frmMostrarRegiao(
                    _configuration.IndicadorPosicaoX.Value,
                    _configuration.IndicadorPosicaoY.Value,
                    _configuration.IndicadorLargura.Value,
                    _configuration.IndicadorAltura.Value,
                    _configuration.IndicadorMiraPosicaoX.Value,
                    _configuration.IndicadorMiraPosicaoY.Value);

                mostrarIndicador.ShowDialog();
            }

        }
    }
}
