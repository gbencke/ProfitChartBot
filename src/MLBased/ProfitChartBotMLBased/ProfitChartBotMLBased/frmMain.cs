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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmConfigure(new ProfitChartBotScanner.ProfitChartBotMLBasedConfiguration());
            var result = frm.ShowDialog();
        }
    }
}
