using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProfitChartBotScanner;

namespace ProfitChartBotMLBased
{
    public partial class frmConfigure : Form
    {
        private ProfitChartBotMLBasedConfiguration _currentConfiguration;
        public frmConfigure(ProfitChartBotMLBasedConfiguration currentConfiguration)
        {
            _currentConfiguration = currentConfiguration;
            InitializeComponent();
        }

        private void RefreshControls()
        {
            if (!(_currentConfiguration.IndicatorsRegion == null))
            {
                txtIndicatorsRegion.Text = String.Format("{0}x{1}x{2}x{3}",
                    _currentConfiguration.IndicatorsRegion.X,
                    _currentConfiguration.IndicatorsRegion.Y,
                    _currentConfiguration.IndicatorsRegion.Width,
                    _currentConfiguration.IndicatorsRegion.Height);
            }
            if (!(_currentConfiguration.StartLongPosition == null))
            {
                txtLongPosition.Text = String.Format("{0}x{1}",
                    _currentConfiguration.StartLongPosition.X,
                    _currentConfiguration.StartLongPosition.Y);
            }
            if (!(_currentConfiguration.StartShortPosition == null))
            {
                txtShortPosition.Text = String.Format("{0}x{1}",
                    _currentConfiguration.StartShortPosition.X,
                    _currentConfiguration.StartShortPosition.Y);
            }
            if (!(_currentConfiguration.ClosePositions == null))
            {
                txtClosePositions.Text = String.Format("{0}x{1}",
                    _currentConfiguration.ClosePositions.X,
                    _currentConfiguration.ClosePositions.Y);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIndicatorsRegion.Text))
            {
                MessageBox.Show("Please select the indicators Region...", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtIndicatorsRegion.Focus();
                return;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hasIndicators = _currentConfiguration.HasIndicatorsRegion();

            int? X = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.X : null;
            int? Y = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.Y : null;
            int? Width = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.Width : null;
            int? Height = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.Height : null;

            var frm = new frmSelectRegion(X, Y, Width, Height, "Select Indicator Region", true);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _currentConfiguration.IndicatorsRegion = frm.ResultingRectangle;
            }

            RefreshControls();

        }

        private void btnLongPosition_Click(object sender, EventArgs e)
        {
            bool hasIndicators = _currentConfiguration.HasIndicatorsRegion();

            int? X = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.X : null;
            int? Y = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.Y : null;
            int? Width = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.Width : null;
            int? Height = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.Height : null;

            var frm = new frmSelectRegion(X, Y, Width, Height, "Select Long Button Position", false);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _currentConfiguration.StartLongPosition = frm.ResultingPoint;
            }

            RefreshControls();
        }

        private void btnShortPosition_Click(object sender, EventArgs e)
        {
            bool hasIndicators = _currentConfiguration.HasIndicatorsRegion();

            int? X = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.X : null;
            int? Y = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.Y : null;
            int? Width = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.Width : null;
            int? Height = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.Height : null;

            var frm = new frmSelectRegion(X, Y, Width, Height, "Select Short Button Position", false);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _currentConfiguration.StartShortPosition = frm.ResultingPoint;
            }

            RefreshControls();
        }

        private void frmConfigure_Load(object sender, EventArgs e)
        {
            RefreshControls();
        }

        private void btnClosePositions_Click(object sender, EventArgs e)
        {
            bool hasIndicators = _currentConfiguration.HasIndicatorsRegion();

            int? X = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.X : null;
            int? Y = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.Y : null;
            int? Width = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.Width : null;
            int? Height = hasIndicators ? (int?)_currentConfiguration.IndicatorsRegion.Height : null;

            var frm = new frmSelectRegion(X, Y, Width, Height, "Select Close Positions", false);

            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                _currentConfiguration.ClosePositions = frm.ResultingPoint;
            }

            RefreshControls();
        }
    }
}
