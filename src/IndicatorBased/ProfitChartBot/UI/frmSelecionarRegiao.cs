using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitChartBot
{
    public partial class frmSelecionarRegiao : Form
    {
        private int _larguraMira;
        private int _alturaMira;
        private String _tituloJanela;
        private int _posicaoMiraX;
        private int _posicaoMiraY;
        private int? _larguraJanela;
        private int? _alturaJanela;
        private int? _posicaoX;
        private int? _posicaoY;
        private bool _finishedLoading = false;

        public int PosicaoX { get { return _posicaoX.Value; } }
        public int PosicaoY { get { return _posicaoY.Value; } }
        public int LarguraJanela { get { return _larguraJanela.Value; } } 
        public int AlturaJanela {  get { return _alturaJanela.Value; } }
        public int PosicaoMiraX { get { return _posicaoMiraX; } }
        public int PosicaoMiraY { get { return _posicaoMiraY; } }

        public frmSelecionarRegiao(
            int? X,
            int? Y,
            int? Largura,
            int? Altura,
            string TituloJanela)
        {
            InitializeComponent();
            TransparencyKey = Color.FromArgb(255, 255, 0);
            _tituloJanela = TituloJanela;
            if (X.HasValue)
            {
                _posicaoX = X.Value;
            }
            if (Y.HasValue)
            {
                _posicaoY = Y.Value;
            }
            if (Largura.HasValue)
            {
                _larguraJanela = Largura.Value;
            }
            if (Altura.HasValue)
            {
                _alturaJanela = Altura.Value;
            }

        }

        private void frmSelecionarRegiao_Paint(object sender, PaintEventArgs e)
        {

            SolidBrush transparentBrush = new SolidBrush(Color.FromArgb(255, 255, 0));

            _larguraMira = (this.Width - 30) / 2;
            _alturaMira = (this.Height - 100) / 2;

            e.Graphics.FillRectangle(transparentBrush, new Rectangle(
                5,
                5,
                _larguraMira - 1,
                _alturaMira - 1));
            e.Graphics.FillRectangle(transparentBrush, new Rectangle(
                5 + _larguraMira + 1,
                5,
                _larguraMira - 1,
                _alturaMira - 1));
            e.Graphics.FillRectangle(transparentBrush, new Rectangle(
                5,
                5 + _alturaMira + 1,
                _larguraMira - 1,
                _alturaMira - 1));
            e.Graphics.FillRectangle(transparentBrush, new Rectangle(
                5 + _larguraMira + 1,
                5 + _alturaMira + 1,
                _larguraMira - 1,
                _alturaMira - 1));

        }

        private void ReposicionarBotao()
        {
            if (_finishedLoading)
            {
                this.btnSelecionar.Left = this.Width - (200 - 80);
                this.btnSelecionar.Top = this.Height - (100 - 15);
                this.lblPosicao.Top = btnSelecionar.Top + 5;

                _larguraJanela = this.Width;
                _alturaJanela = this.Height;
                _posicaoX = this.Left;
                _posicaoY = this.Top;

                _posicaoMiraX = 5 + _larguraMira + 1 + _posicaoX.Value + 5;
                _posicaoMiraY = 5 + _alturaMira + 1 + _posicaoY.Value + 30;

                lblPosicao.Text = String.Format("{0}x{1}", _posicaoMiraX, _posicaoMiraY);
            }
        }

        private void frmSelecionarRegiao_Resize(object sender, EventArgs e)
        {
            ReposicionarBotao();
        }

        private void frmSelecionarRegiao_Load(object sender, EventArgs e)
        {
            Text = _tituloJanela;
            MinimumSize = new Size(310, 200);

            if (_posicaoX.HasValue)
            {
                Left = _posicaoX.Value;
            }
            if (_posicaoY.HasValue)
            {
                Top = _posicaoY.Value;
            }
            if (_larguraJanela.HasValue)
            {
                Width = _larguraJanela.Value;
            }
            if (_alturaJanela.HasValue)
            {
                Height = _alturaJanela.Value;
            }

            _finishedLoading = true;

            ReposicionarBotao();

        }

        private void frmSelecionarRegiao_LocationChanged(object sender, EventArgs e)
        {
            ReposicionarBotao();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
