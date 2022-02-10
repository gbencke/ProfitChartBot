using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ProfitChartBotScanner;

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

        private ScreenRectangle _ResultingRectangle = null;
        private ScreenPoint _ResultingPoint = null;

        private int PositionX { get { return _positionX.Value; } }
        private int PositionY { get { return _positionY.Value; } }
        private int WindowWidth { get { return _windowWidth.Value; } }
        private int WindowHeight { get { return _windowHeigth.Value; } }
        private int PositionSigthX { get { return _positionSightX; } }
        private int PositionSightY { get { return _positionSightY; } }
        private int RectLeft
        {
            get
            {
                return Left + 15;
            }
        }
        private int RectTop
        {
            get
            {
                return Top + 35;
            }
        }
        private int RectWidth
        {
            get
            {
                return Width - 35;
            }
        }
        private int RectHeight
        {
            get
            {
                return Height - 100;
            }
        }

        public ScreenRectangle ResultingRectangle
        {
            get
            {
                return _ResultingRectangle;
            }
        }
        public ScreenPoint ResultingPoint
        {
            get
            {
                return _ResultingPoint;
            }
        }

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
            int ActiveWidth = this.Width - 30;
            int ActiveHeight = this.Height - 100;

            SolidBrush transparentBrush = new SolidBrush(Color.FromArgb(255, 255, 0));

            _widthSight = (ActiveWidth) / 2;
            _heightSight = (ActiveHeight) / 2;

            if (!_RegionSelectMode)
            {
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
            else
            {
                e.Graphics.FillRectangle(transparentBrush, new Rectangle(
                    5,
                    5,
                    ActiveWidth,
                    ActiveHeight));
            }

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

                if (!_RegionSelectMode)
                {
                    lblPosicao.Text = String.Format("{0}x{1}", _positionSightX, _positionSightY);
                }
                else
                {
                    lblPosicao.Text = String.Format("{0}x{1}x{2}x{3}", RectLeft, RectTop, RectWidth, RectHeight);
                }
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
            if (_RegionSelectMode)
            {
                _ResultingRectangle = new ScreenRectangle(RectLeft, RectTop, RectWidth, RectHeight);
            }
            else
            {
                _ResultingPoint = new ScreenPoint(_positionSightX, _positionSightY);
                /* Rectangle rect = new Rectangle( _positionSightX - 20, _positionSightY - 20, 40, 40);

                using (Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb)) {
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
                        bmp.Save("C:\\tmp\\teste.jpg", ImageFormat.Jpeg);
                    }
                }
                */
            }

            DialogResult = DialogResult.OK;

        }
    }
}
