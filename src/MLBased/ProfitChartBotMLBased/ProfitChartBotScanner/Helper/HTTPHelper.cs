using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ProfitChartBotScanner
{
    public static class HTTPHelper
    {
        public static ModelParameters GetParameters(string URL, int Timeout)
        {
            HttpWebRequest Request = (HttpWebRequest)HttpWebRequest.Create(URL);

            Request.Timeout = Timeout;
            Request.Method = "GET";

            HttpWebResponse Response = null;

            try
            {
                Response = (HttpWebResponse)Request.GetResponse();
            }
            catch (WebException ex)
            {
                throw ex;
            }

            System.IO.StreamReader reader = new System.IO.StreamReader(Response.GetResponseStream());
            string ReturnedModelParameters = reader.ReadToEnd();
            ModelParameters ReturnedModelParametersJSON = JsonConvert.DeserializeObject<ModelParameters>(ReturnedModelParameters);

            return ReturnedModelParametersJSON;
        }

        public static string PostQuote(string URL, QuoteToPost toPost, int Timeout)
        {

            try
            {
                string CleanURL = URL.EndsWith("/") ? URL.Substring(0, URL.Length - 1) : URL;
                string CorrectURL = String.Format("{0}/{1}/{2}/{3}/", CleanURL, toPost.Exchange, toPost.Asset, toPost.TimeFrame);
                HttpWebRequest Request = (HttpWebRequest)HttpWebRequest.Create(CorrectURL);

                Request.ContentType = "application/json";
                Request.Timeout = Timeout;
                Request.Method = "POST";

                using (var streamWriter = new StreamWriter(Request.GetRequestStream()))
                {
                    string QuoteJSON = JsonConvert.SerializeObject(toPost);
                    streamWriter.Write(QuoteJSON);
                }

                var httpResponse = (HttpWebResponse)Request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
            }
            catch (WebException ex)
            {
                if(!(ex.Message.Contains("409") && ex.Message.Contains("Conflict"))){
                    throw ex;
                }
                return ex.Message;
            }

        }
        public static SignalPrediction GetSignal(string URL, string Exchange, string Asset, string Timeframe, string Date, string Time, int Timeout)
        {

            try
            {
                string CleanURL = URL.EndsWith("/") ? URL.Substring(0, URL.Length - 1) : URL;
                string CorrectURL = String.Format("{0}/{1}/{2}/{3}/{4}/{5}/", CleanURL, Exchange, Asset, Timeframe, Date, Time);
                HttpWebRequest Request = (HttpWebRequest)HttpWebRequest.Create(CorrectURL);

                Request.Timeout = Timeout;
                Request.Method = "GET";

                HttpWebResponse Response = null;

                try
                {
                    Response = (HttpWebResponse)Request.GetResponse();
                }
                catch (WebException ex)
                {
                    throw ex;
                }

                StreamReader reader = new StreamReader(Response.GetResponseStream());
                string ReturnedSignal = reader.ReadToEnd();
                var ReturnedSignalJson = JsonConvert.DeserializeObject<SignalPrediction>(ReturnedSignal);

                return ReturnedSignalJson;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }


    }
}
