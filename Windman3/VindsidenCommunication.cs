using System;
using System.Configuration;
using System.IO;
using System.Net;
using NLog;

namespace Windman3
{
    public class VindsidenCommunication
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public bool SendData(Measure pMeasure)
        {
            string version = ConfigurationManager.AppSettings["WindComVersion"].ToString();
            string stationId = ConfigurationManager.AppSettings["WindComStationId"].ToString();
            string stationCC = ConfigurationManager.AppSettings["WindComStationCC"].ToString();
            string userAgent = ConfigurationManager.AppSettings["WindComUserAgent"].ToString();
            string serverBaseUrl = ConfigurationManager.AppSettings["WindComBaseUrl"].ToString();

            WebClient client = new WebClient();
            client.Headers.Add("user-agent", userAgent);

            String url = serverBaseUrl;
            url += "v=" + version;
            url += "&ID=" + stationId;
            url += "&CC=" + stationCC;
            url += "&Wind=" + pMeasure.WindSpeedAverageAsString;
            url += "&WindStDev=" + "";
            url += "&WindMin=" + pMeasure.WindSpeedMinimumAsString;
            url += "&WindMax=" + pMeasure.WindSpeedMaximumAsString;
            url += "&Dir=" + pMeasure.WindDirectionAsString;
            url += "&DirV=" + "";
            url += "&DirStDev=" + "";
            url += "&Temp1=" + pMeasure.TemperatureAsString;
            url += "&Battery=" + pMeasure.BatteryVoltageAsString;

            Stream data = null;
            string s = string.Empty;
            StreamReader reader = null;
            try
            {
                data = client.OpenRead(url);
                reader = new StreamReader(data);
                s = reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                logger.LogException(LogLevel.Error, ex.Message, ex);
                //throw;
            }
            finally
            {
                if (data != null)
                {
                    data.Close();
                }
                if (reader != null)
                {
                    reader.Close();
                }     
            }

            logger.Log(LogLevel.Info, url);

            return s.Contains("OK");
        }
    }
}
