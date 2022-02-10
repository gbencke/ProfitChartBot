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

        public ProfitChartBotMLBasedConfiguration Configuration
        {
            get
            {
                return _currentConfiguration;
            }
        }
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
            if (!(String.IsNullOrEmpty(_currentConfiguration.TesseractExecutable)))
            {
                txtTesseractExecutable.Text = _currentConfiguration.TesseractExecutable;
            }
            if (!(String.IsNullOrEmpty(_currentConfiguration.TessDataLocation)))
            {
                txtTessDataLocation.Text = _currentConfiguration.TessDataLocation;
            }
            if (!(String.IsNullOrEmpty(_currentConfiguration.TextLogDir)))
            {
                txtTextLogDir.Text = _currentConfiguration.TextLogDir;
            }
            if (!(String.IsNullOrEmpty(_currentConfiguration.ImageLogDir)))
            {
                txtImageLogDir.Text = _currentConfiguration.ImageLogDir;
            }
            if (!(String.IsNullOrEmpty(_currentConfiguration.GETParametersURL)))
            {
                txtGETParametersURL.Text = _currentConfiguration.GETParametersURL;
            }
            if (!(String.IsNullOrEmpty(_currentConfiguration.GETPredictionURL)))
            {
                txtGETPredictionURL.Text = _currentConfiguration.GETPredictionURL;
            }
            if (!(String.IsNullOrEmpty(_currentConfiguration.POSTQuoteURL)))
            {
                txtPOSTQuoteURL.Text = _currentConfiguration.POSTQuoteURL;
            }
            if (_currentConfiguration.IntervalScanning.HasValue)
            {
                txtProfitScanInterval.Text = _currentConfiguration.IntervalScanning.Value.ToString();
            }

            btnOK.Enabled = _currentConfiguration.IsDataComplete();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIndicatorsRegion.Text))
            {
                MessageBox.Show("Please select the indicators Region...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            txtImageLogDir.Text = ".\\logimg";
            txtTextLogDir.Text = ".\\logtext";

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

        private void btnTesseractExecutable_Click(object sender, EventArgs e)
        {

            if (searchTesseractEXE.ShowDialog() == DialogResult.OK)
            {
                _currentConfiguration.TesseractExecutable = searchTesseractEXE.FileName;
            }

            RefreshControls();
        }

        private void btnTessdataLocation_Click(object sender, EventArgs e)
        {
            if (searchTessdataFolder.ShowDialog() == DialogResult.OK)
            {
                _currentConfiguration.TessDataLocation = searchTessdataFolder.SelectedPath;
            }

            RefreshControls();
        }

        private void frmConfigure_Click(object sender, EventArgs e)
        {

        }

        private void txtGETParametersURL_TextChanged(object sender, EventArgs e)
        {
            _currentConfiguration.GETParametersURL = txtGETParametersURL.Text;

            RefreshControls();
        }

        private void txtPOSTQuoteURL_TextChanged(object sender, EventArgs e)
        {
            _currentConfiguration.POSTQuoteURL = txtPOSTQuoteURL.Text;

            RefreshControls();
        }

        private void txtGETPredictionURL_TextChanged(object sender, EventArgs e)
        {
            _currentConfiguration.GETPredictionURL = txtGETPredictionURL.Text;

            RefreshControls();
        }

        private void btnTextLogDirLocation_Click(object sender, EventArgs e)
        {
            if (searchTessdataFolder.ShowDialog() == DialogResult.OK)
            {
                _currentConfiguration.TextLogDir = searchTessdataFolder.SelectedPath;
            }

            RefreshControls();
        }

        private void btnImageLogDir_Click(object sender, EventArgs e)
        {
            if (searchTessdataFolder.ShowDialog() == DialogResult.OK)
            {
                _currentConfiguration.ImageLogDir = searchTessdataFolder.SelectedPath;
            }

            RefreshControls();
        }

        private void txtTextLogDir_TextChanged(object sender, EventArgs e)
        {
            _currentConfiguration.TextLogDir = txtTextLogDir.Text;

            RefreshControls();
        }

        private void txtImageLogDir_TextChanged(object sender, EventArgs e)
        {
            _currentConfiguration.ImageLogDir = txtImageLogDir.Text;

            RefreshControls();
        }

        private void txtProfitScanInterval_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProfitScanInterval.Text))
            {
                _currentConfiguration.IntervalScanning = null;
                return;
            }

            _currentConfiguration.IntervalScanning = Convert.ToInt32(txtProfitScanInterval.Text);

            RefreshControls();
        }

        private void txtProfitScanInterval_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtProfitScanInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
