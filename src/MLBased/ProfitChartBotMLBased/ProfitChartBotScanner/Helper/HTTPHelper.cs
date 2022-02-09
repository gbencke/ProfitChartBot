using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
    }
}
