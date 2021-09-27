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

        private void frmMain_Load(object sender, EventArgs e)
        {
            _configuration = new ProfitChartBotConfiguration();

        }
    }
}
