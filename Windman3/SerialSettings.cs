using System.Configuration;
using System.IO.Ports;

namespace Windman3
{
    public class SerialSettings
    {
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public int DataBits { get; set; }
        public Parity Parity { get; set; }
        public StopBits StopBits { get; set; }
        public string FlowControl { get; set; }

        public static SerialSettings NewFromConfigFile()
        {
            SerialSettings ss = new SerialSettings();
            ss.PortName = ConfigurationManager.AppSettings["PortName"];
            ss.BaudRate = int.Parse(ConfigurationManager.AppSettings["BaudRate"]);
            ss.DataBits = int.Parse(ConfigurationManager.AppSettings["DataBits"]);
            switch (ConfigurationManager.AppSettings["Parity"])
            {
                case "Odd":
                    ss.Parity = Parity.Odd;
                    break;
                case "Even":
                    ss.Parity = Parity.Even;
                    break;
                case "Mark":
                    ss.Parity = Parity.Mark;
                    break;
                case "None":
                    ss.Parity = Parity.None;
                    break;
                case "Space":
                    ss.Parity = Parity.Space;
                    break;
                default:
                    break;
            }
            switch (ConfigurationManager.AppSettings["StopBits"])
            {
                case "None":
                    ss.StopBits = StopBits.None;
                    break;
                case "One":
                    ss.StopBits = StopBits.One;
                    break;
                case "OnePointFive":
                    ss.StopBits = StopBits.OnePointFive;
                    break;
                case "Two":
                    ss.StopBits = StopBits.Two;
                    break;
                default:
                    break;
            }
            return ss;
        }
    }
}
