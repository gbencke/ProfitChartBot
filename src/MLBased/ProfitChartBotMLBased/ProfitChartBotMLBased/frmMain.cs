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
    public partial class frmMain : Form, IObserverProfitChartBotScanner
    {
        private ProfitChartBotMLBasedConfiguration _configuration;
        private String _currentExecutableFolder;
        private String _currentConfigurationFile;
        private String _currentConfigurationJSON;
        private IProfitChartBotScannerService _service;

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

                _service = new ProfitChartBotScannerService();
                _service.Initialize(_configuration, this);

                RefreshControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _service.StartExecution();
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

            if (_configuration == null || !_configuration.IsDataComplete())
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

                    _service = new ProfitChartBotScannerService();
                    _service.Initialize(_configuration, this);

                    RefreshControls();

                }
                else
                {
                    _configuration = new ProfitChartBotMLBasedConfiguration();

                    RefreshControls();
                }

                string fullTmpLogPath = (new FileInfo(_configuration.TextLogDir)).FullName;
                string LogFile = (new FileInfo(_configuration.TextLogDir + "\\" + (DateTime.Now).ToString("yyMMddhhmmss") + ".txt").FullName);

                ProfitChartScannerLogging.InitializeLogger(LogFile);

                ProfitChartScannerLogging.Info("Initialized ProfitChartBot");

                timerObservations.Enabled = true;
                this.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message + ex.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private List<Observation> _Events = new List<Observation>();

        public void Observe(Observation Observed)
        {
            lock (this)
            {
                _Events.Add(Observed);
            }
        }

        private void timerObservations_Tick(object sender, EventArgs e)
        {
            lock (this)
            {
                try
                {
                    foreach (var Observed in _Events)
                    {
                        if (Observed.Type == ObservationType.ScanResult)
                        {
                            txtDate.Text = Observed.Result.ProfitChartDate.ToString();
                            txtTime.Text = Observed.Result.ProfitChartTime.ToString();
                            txtLow.Text = Observed.Result.ProfitChartLow.ToString();
                            txtHigh.Text = Observed.Result.ProfitChartHigh.ToString();
                            txtLastClose.Text = Observed.Result.ProfitChartLastClose.ToString();
                            txtLastHigh.Text = Observed.Result.ProfitChartLastHigh.ToString();
                            txtLastLow.Text = Observed.Result.ProfitChartLastLow.ToString();
                            txtLastOpen.Text = Observed.Result.ProfitChartLastOpen.ToString();
                            txtLastVolume.Text = Observed.Result.ProfitChartLastVolume.ToString();
                            txtOrderStatus.Text = Observed.Result.ProfitChartBotCurrentOrderStatus.ToString();
                            txtPredicted.Text = Observed.Result.GetPredictedBoundary();
                            this.Focus();
                        }

                        if (!String.IsNullOrEmpty(Observed.Message))
                        {
                            statusStrip1.Items[0].Text = Observed.Message;
                        }
                    }
                    _Events.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
