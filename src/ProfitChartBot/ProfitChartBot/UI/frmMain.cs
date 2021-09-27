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


namespace ProfitChartBot
{
    public partial class frmMain : Form
    {

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
            _configuration = new ProfitChartBotConfiguration();

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
            }

        }
    }
}
