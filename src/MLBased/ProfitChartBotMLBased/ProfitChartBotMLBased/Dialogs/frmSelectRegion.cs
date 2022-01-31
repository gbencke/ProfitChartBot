using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitChartBotMLBased
{
    public partial class frmSelectRegion : Form
    {
        private int _widthSight;
        private int _heightSight;
        private String _WindowCaption;
        private int _positionSightX;
        private int _positionSightY;
        private int? _windowWidth;
        private int? _windowHeigth;
        private int? _positionX;
        private int? _positionY;
        private bool _finishedLoading = false;
        private bool _RegionSelectMode;

        public int PositionX { get { return _positionX.Value; } }
        public int PositionY { get { return _positionY.Value; } }
        public int WindowWidth { get { return _windowWidth.Value; } } 
        public int WindowHeight {  get { return _windowHeigth.Value; } }
        public int PositionSigthX { get { return _positionSightX; } }
        public int PositionSightY { get { return _positionSightY; } }

        public frmSelectRegion(
            int? X,
            int? Y,
            int? Width,
            int? Height,
            string WindowCaption,
            bool RegionSelectMode)
        {
            InitializeComponent();
            TransparencyKey = Color.FromArgb(255, 255, 0);
            _WindowCaption = WindowCaption;
            if (X.HasValue)
            {
                _positionX = X.Value;
            }
            if (Y.HasValue)
            {
                _positionY = Y.Value;
            }
            if (Width.HasValue)
            {
                _windowWidth = Width.Value;
            }
            if (Height.HasValue)
            {
                _windowHeigth = Height.Value;
            }

            _RegionSelectMode = RegionSelectMode;
        }

        private void frmSelecionarRegiao_Paint(object sender, PaintEventArgs e)
        {

            SolidBrush transparentBrush = new SolidBrush(Color.FromArgb(255, 255, 0));

            _widthSight = (this.Width - 30) / 2;
            _heightSight = (this.Height - 100) / 2;

            e.Graphics.FillRectangle(transparentBrush, new Rectangle(
                5,
                5,
                _widthSight - 1,
                _heightSight - 1));
            e.Graphics.FillRectangle(transparentBrush, new Rectangle(
                5 + _widthSight + 1,
                5,
                _widthSight - 1,
                _heightSight - 1));
            e.Graphics.FillRectangle(transparentBrush, new Rectangle(
                5,
                5 + _heightSight + 1,
                _widthSight - 1,
                _heightSight - 1));
            e.Graphics.FillRectangle(transparentBrush, new Rectangle(
                5 + _widthSight + 1,
                5 + _heightSight + 1,
                _widthSight - 1,
                _heightSight - 1));

        }

        private void ReposicionarBotao()
        {
            if (_finishedLoading)
            {
                this.btnSelecionar.Left = this.Width - (200 - 80);
                this.btnSelecionar.Top = this.Height - (100 - 15);
                this.lblPosicao.Top = btnSelecionar.Top + 5;

                _windowWidth = this.Width;
                _windowHeigth = this.Height;
                _positionX = this.Left;
                _positionY = this.Top;

                _positionSightX = 5 + _widthSight + 1 + _positionX.Value + 5;
                _positionSightY = 5 + _heightSight + 1 + _positionY.Value + 30;

                lblPosicao.Text = String.Format("{0}x{1}", _positionSightX, _positionSightY);
            }
        }

        private void frmSelecionarRegiao_Resize(object sender, EventArgs e)
        {
            ReposicionarBotao();
        }

        private void frmSelecionarRegiao_Load(object sender, EventArgs e)
        {
            Text = _WindowCaption;
            MinimumSize = new Size(310, 200);

            if (_positionX.HasValue)
            {
                Left = _positionX.Value;
            }
            if (_positionY.HasValue)
            {
                Top = _positionY.Value;
            }
            if (_windowWidth.HasValue)
            {
                Width = _windowWidth.Value;
            }
            if (_windowHeigth.HasValue)
            {
                Height = _windowHeigth.Value;
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
