using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Windman3
{
    public class VindsidenCommunication
    {
        private static string _serverBaseUrl;
        private static VindsidenCommunication _instance;

        protected VindsidenCommunication()
        {
            _serverBaseUrl = @"http://www.objo.net/wind/wrm.aspx?";
        }

        public static VindsidenCommunication Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new VindsidenCommunication();
            }

            return _instance;
        }

        public static string ServerBaseUrl
        {
            get { return _serverBaseUrl; }
            set { _serverBaseUrl = value; }
        }


        public string SendData(string version, string stationId, string StationCC)
        {
            //String url;
            //url = serverBase;
            //url += "v=" + version;
            //url += "&ID=" + stationId;
            //url += "&CC=" + stationCC;
            //url += "&Wind=" + Utilities.FormatDouble(windAverageSpeed, 1);
            //url += "&WindStDev=" + Utilities.FormatDouble(windSpeedStDev, 1);
            //url += "&WindMin=" + Utilities.FormatDouble(windMinSpeed, 1);
            //url += "&WindMax=" + Utilities.FormatDouble(windMaxSpeed, 1);
            //url += "&Dir=" + Utilities.FormatDouble(windAverageDirection, 0);
            //url += "&DirV=" + Utilities.FormatDouble(windDirectionV, 0);
            //url += "&DirStDev=" + Utilities.FormatDouble(windDirectionStDev, 1);
            //url += "&Temp1=" + Utilities.FormatDouble(temperature1, 1);
            //url += "&Battery=" + Utilities.FormatDouble(batteryVoltage, 3);



            // Create a request using a URL that can receive a post. 
            WebRequest request = WebRequest.Create(_serverBaseUrl);
            // Set the Method property of the request to POST.
            request.Method = "GET";
            // Create POST data and convert it to a byte array.
            string postData = "This is a test that posts this string to a Web server.";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";
            // Set the ContentLength property of the WebRequest.
            request.ContentLength = byteArray.Length;
            // Get the request stream.
            Stream dataStream = request.GetRequestStream();
            // Write the data to the request stream.
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            //Console.WriteLine (((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            //Console.WriteLine (responseFromServer);
            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
        }
    }
}
