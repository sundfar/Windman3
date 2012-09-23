using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Windman3
{
    public class Measure
    {
        //public DateTime DateAndTime { get; set; }
        public decimal WindSpeedMinimum { get; set; }
        public decimal WindSpeedMaximum { get; set; }
        public decimal WindSpeedAverage { get; set; }
        public decimal WindDirection { get; set; }
        public decimal Temperature { get; set; }
        public decimal BatteryVoltage { get; set; }

        public string WindSpeedMinimumAsString
        {
            get
            { 
                return WindSpeedMinimum.ToString("0.##", CultureInfo.InvariantCulture); 
            }
        }

        public string WindSpeedMaximumAsString
        {
            get
            {
                return WindSpeedMaximum.ToString("0.##", CultureInfo.InvariantCulture);
            }
        }

        public string WindSpeedAverageAsString
        {
            get
            {
                return WindSpeedAverage.ToString("0.##", CultureInfo.InvariantCulture);
            }
        }

        public string WindDirectionAsString
        {
            get
            {
                return WindDirection.ToString("0.##", CultureInfo.InvariantCulture);
            }
        }

        public string TemperatureAsString
        {
            get
            {
                return Temperature.ToString("0.##", CultureInfo.InvariantCulture);
            }
        }

        public string BatteryVoltageAsString
        {
            get
            {
                return BatteryVoltage.ToString("0.##", CultureInfo.InvariantCulture);
            }
        }
    }
}
