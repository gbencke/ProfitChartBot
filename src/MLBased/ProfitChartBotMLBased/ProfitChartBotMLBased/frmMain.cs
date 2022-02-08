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
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace ProfitChartBotMLBased
{
    public partial class frmMain : Form
    {
        private ProfitChartBotMLBasedConfiguration _configuration;
        private String _currentExecutableFolder;
        private String _currentConfigurationFile;
        private String _currentConfigurationJSON;

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
            try
            {
                var frm = new frmConfigure(_configuration);
                var result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _currentConfigurationJSON = JsonConvert.SerializeObject(frm.Configuration, Formatting.Indented);
                    File.WriteAllText(_currentConfigurationFile, _currentConfigurationJSON);
                }

                RefreshControls();

            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HideAllControls()
        {
            lblNeedToConfigure.Visible = false;
            statusStrip1.Items[0].Text = "";
        }
        private void ShowExecutionControls()
        {


        }
        private void ShowNeedToConfigureWarning()
        {
            lblNeedToConfigure.Visible = true;
            statusStrip1.Items[0].Text = "Please Configure the application by selecting the Configure option on the Menu Bar...";
        }

        private void RefreshControls()
        {
            HideAllControls();

            if(_configuration == null || !_configuration.IsDataComplete())
            {
                ShowNeedToConfigureWarning();
            }
            else 
            {
                ShowExecutionControls();
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Assembly curAssembly = Assembly.GetEntryAssembly();

                _currentExecutableFolder = curAssembly.Location.Replace(curAssembly.ManifestModule.Name, "");
                Environment.CurrentDirectory = _currentExecutableFolder;

                _currentConfigurationFile = String.Format("{0}profitchartbot.conf.json", _currentExecutableFolder);


                if (File.Exists(_currentConfigurationFile))
                {
                    _currentConfigurationJSON = File.ReadAllText(_currentConfigurationFile);
                    _configuration = JsonConvert.DeserializeObject<ProfitChartBotMLBasedConfiguration>(_currentConfigurationJSON);

                    if (!Directory.Exists(_configuration.TextLogDir))
                    {
                        Directory.CreateDirectory(_configuration.TextLogDir);
                    }

                    if (!Directory.Exists(_configuration.ImageLogDir))
                    {
                        Directory.CreateDirectory(_configuration.ImageLogDir);
                    }

                    RefreshControls();

                }
                else
                {
                    _configuration = new ProfitChartBotMLBasedConfiguration();

                    RefreshControls();
                }


            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
