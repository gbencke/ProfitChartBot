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
    public partial class frmMostrarRegiao : Form
    {
        private int _posicaoX;
        private int _posicaoY;
        private int _largura;
        private int _altura;
        private int _miraX;
        private int _miraY;
        public frmMostrarRegiao(
            int posicaoX,
            int posicaoY,
            int largura,
            int altura,
            int miraX,
            int miraY)
        {
            InitializeComponent();
            _posicaoX = posicaoX;
            _posicaoY = posicaoY;
            _largura = largura;
            _altura = altura;
            _miraX = miraX;
            _miraY = miraY;
        }

        private void frmMostrarRegiao_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush transparentBrush = new SolidBrush(Color.FromArgb(255, 255, 0));
            SolidBrush normalBrush = new SolidBrush(Color.FromArgb(255, 255, 255));


            e.Graphics.FillRectangle(transparentBrush, new Rectangle(
                5,
                5,
                _largura - 10,
                _altura - 10));

            e.Graphics.FillRectangle(normalBrush, new Rectangle(
                (_miraX - _posicaoX) - 5,
                (_miraY - _posicaoY) - 5,
                10,
                10));

        }

        private void frmMostrarRegiao_Load(object sender, EventArgs e)
        {
            TransparencyKey = Color.FromArgb(255, 255, 0);
            Left = _posicaoX;
            Top = _posicaoY;
            Width = _largura;
            Height = _altura;
        }

        private void frmMostrarRegiao_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmMostrarRegiao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.OK;
                e.SuppressKeyPress = true;
            }

        }
    }
}
