using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                return WindSpeedMinimum.ToString("N"); 
            }
        }

        public string WindSpeedMaximumAsString
        {
            get
            {
                return WindSpeedMaximum.ToString("N");
            }
        }

        public string WindSpeedAverageAsString
        {
            get
            {
                return WindSpeedAverage.ToString("N");
            }
        }

        public string WindDirectionAsString
        {
            get
            {
                return WindDirection.ToString("N");
            }
        }

        public string TemperatureAsString
        {
            get
            {
                return Temperature.ToString("N");
            }
        }

        public string BatteryVoltageAsString
        {
            get
            {
                return BatteryVoltage.ToString("N");
            }
        }
    }
}
