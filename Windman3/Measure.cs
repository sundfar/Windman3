using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Windman3
{
    public class Measure
    {
        public DateTime DateAndTime { get; set; }
        public decimal WindSpeedMinimum { get; set; }
        public decimal WindSpeedMaximum { get; set; }
        public decimal WindSpeedAverage { get; set; }
        public decimal WindDirection { get; set; }
        public decimal Temperature { get; set; }
        public decimal BatteryVoltage { get; set; }
    }
}
