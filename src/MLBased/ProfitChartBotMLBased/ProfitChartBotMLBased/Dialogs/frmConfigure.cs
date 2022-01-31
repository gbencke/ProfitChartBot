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

        private void button7_Click(object sender, EventArgs e)
        {
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

        }
    }
}
