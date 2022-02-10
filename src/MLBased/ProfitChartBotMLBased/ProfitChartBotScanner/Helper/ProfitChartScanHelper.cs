using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;

namespace ProfitChartBotScanner
{
    public class ProfitChartScanHelper
    {
        private ProfitChartBotMLBasedConfiguration _configuration;

        private string _tmpImagePath = null;
        private string _lastImagePath = null;
        private string _tesseractLastDataReceived = null;
            
        private bool IsSameAsOld(string img1, string img2)
        {
            return false;
        }

        private string getOCRFromTesseract()
        {
            string fullTmpImagePath = (new FileInfo(_tmpImagePath)).FullName;
            string receivedDataFromTesseract = "";

            Process TesseractProcess = new Process();

            if (TesseractProcess.StartInfo.EnvironmentVariables.ContainsKey("TESSDATA_PREFIX"))
            {
                TesseractProcess.StartInfo.EnvironmentVariables.Remove("TESSDATA_PREFIX");
            }
            TesseractProcess.StartInfo.EnvironmentVariables.Add("TESSDATA_PREFIX", _configuration.TessDataLocation);
            TesseractProcess.StartInfo.FileName = _configuration.TesseractExecutable;
            TesseractProcess.StartInfo.Arguments = String.Format("{0} stdout", fullTmpImagePath);
            TesseractProcess.StartInfo.UseShellExecute = false;
            TesseractProcess.StartInfo.RedirectStandardOutput = true;
            TesseractProcess.StartInfo.CreateNoWindow = true;
            TesseractProcess.OutputDataReceived += (sender, args) =>
            {
                receivedDataFromTesseract += args.Data + "\n";
            };

            TesseractProcess.Start();
            TesseractProcess.BeginOutputReadLine();
            TesseractProcess.WaitForExit();

            return receivedDataFromTesseract;
        }

        private string MoveTmpImageToImageLog()
        {
            string fullTmpImagePath = (new FileInfo(_tmpImagePath)).FullName;
            string newImageName = (new FileInfo(_configuration.ImageLogDir + "\\" + (DateTime.Now).ToString("yyMMddhhmmss") + ".png").FullName);

            File.Move(fullTmpImagePath, newImageName);

            return newImageName;
        }

        public ProfitChartScanResult GetNextScan()
        {

            Rectangle rect = new Rectangle(
                _configuration.IndicatorsRegion.X,
                _configuration.IndicatorsRegion.Y,
                _configuration.IndicatorsRegion.Width,
                _configuration.IndicatorsRegion.Height);


            using (Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
                    bmp.Save(_tmpImagePath, ImageFormat.Png);
                }
            }

            if (!String.IsNullOrEmpty(_lastImagePath) && 
                IsSameAsOld(_lastImagePath, _tmpImagePath))
            {
                return null;
            }
            else
            {
                _tesseractLastDataReceived = getOCRFromTesseract();
                _lastImagePath = MoveTmpImageToImageLog();
            }


            var ret =  new ProfitChartScanResult(_tesseractLastDataReceived);

            if (ret.IsDataOk)
            {
                return ret;
            }
            else
            {
                return null;
            }
        }

        public ProfitChartScanHelper(ProfitChartBotMLBasedConfiguration configuration)
        {
            _configuration = configuration;
            _tmpImagePath = _configuration.ImageLogDir + "\\profit_tmp.png";
        }

    }
}
