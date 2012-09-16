using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Windman3
{
    public class MeasureManager
    {
        private int _packetSize;
        private Measure _measure;
        private decimal _measureIntervall;
        private decimal _mphFactor;
        private decimal _msFactor;
        private decimal _msbFactor;
        private List<Measure> _measures;

        public string WindMSB { get; set; }
        public string WindLSB { get; set; }
        public string WindMinMSB { get; set; }
        public string WindMinLSB { get; set; }
        public string WindMaxMSB { get; set; }
        public string WindMaxLSB { get; set; }

        public bool IsReady { get; set; }

        public int PacketSize
        {
            get
            {
                return _packetSize;
            }
        }


        public Measure CurrentMeasure
        {
            get 
            {
                if (_measures == null)
                {
                    return new Measure();
                }
                if (_measures.Count == 0)
                {
                    return new Measure();
                }
                Measure averageMeasure = new Measure();
                averageMeasure.WindSpeedMinimum = _measures.Average(m => m.WindSpeedMinimum);
                averageMeasure.WindSpeedMaximum = _measures.Average(m => m.WindSpeedMaximum);
                averageMeasure.WindSpeedAverage = _measures.Average(m => m.WindSpeedAverage);
                averageMeasure.WindDirection = _measures.Average(m => m.WindDirection);
                averageMeasure.Temperature = _measures.Average(m => m.Temperature);
                averageMeasure.BatteryVoltage = _measures.Average(m => m.BatteryVoltage);
                return averageMeasure;
            }
        }

        public MeasureManager()
        {
            _packetSize = Int32.Parse(ConfigurationManager.AppSettings["PacketSize"].ToString());
            _measureIntervall = decimal.Parse(ConfigurationManager.AppSettings["MeasureIntervallInSeconds"].ToString());
            _mphFactor = 2.25M;
            _msFactor = 0.44704M;
            _msbFactor = 256M;
            IsReady = false;
            _measures = new List<Measure>();
            _measure = new Measure();
        }
        public void Add(byte[] pMeasure)
        {
            if (pMeasure.Length == _packetSize)
            {
                Measure m = new Measure();
                m.WindSpeedAverage = CalculateWindSpeedAverage(ToDec(pMeasure[8]), ToDec(pMeasure[9]));
                WindMSB = pMeasure[8].ToString();
                WindLSB = pMeasure[9].ToString();
                WindMinMSB = pMeasure[14].ToString();
                WindMinLSB = pMeasure[15].ToString();
                WindMaxMSB = pMeasure[12].ToString();
                WindMaxLSB = pMeasure[13].ToString();
                m.WindSpeedMinimum = CalculateWindSpeedMinimum(ToDec(pMeasure[14]), ToDec(pMeasure[15]));
                m.WindSpeedMaximum = CalculateWindSpeedMaximum(ToDec(pMeasure[12]), ToDec(pMeasure[13]));
                m.WindDirection = CalculateWindDirection(ToDec(pMeasure[50]), ToDec(pMeasure[51]));
                m.Temperature = CalculateTemperature(ToDec(pMeasure[64]), ToDec(pMeasure[65]));
                m.BatteryVoltage = CalculateBatteryVoltage(ToDec(pMeasure[44]), ToDec(pMeasure[45]));

                _measure = m;
                _measures.Add(m);
                IsReady = true;
            }
            else
            {
                IsReady = false;
            }

            //Measure m = new Measure();

            //if ((pMeasure.Length > 59) && (pMeasure[0] == 35))
            //{
            //    decimal decMSB = decimal.Parse(pMeasure[50].ToString());
            //    decimal decLSB = decimal.Parse(pMeasure[51].ToString());

            //    decimal res = 0.0878906m * ((decMSB * 256) + decLSB);
            //    _measure.WindDirection = res;
            //}
            //else
            //{
            //    IsReady = true;
            //}
        }

        private decimal ToDec(byte pByte)
        {
            return decimal.Parse(pByte.ToString());
        }

        private decimal CalculateWindDirection(decimal pMSB, decimal pLSB)
        {
            return (0.0878906M * ((pMSB * _msbFactor) + pLSB));
        }

        private decimal CalculateWindSpeedAverage(decimal pMSB, decimal pLSB)
        {
            return ((_mphFactor * _msFactor) * ((pMSB * _msbFactor) + pLSB)) / _measureIntervall;
        }

        private decimal CalculateWindSpeedMinimum(decimal pMSB, decimal pLSB)
        {
            return ((_mphFactor * _msFactor) * ((pMSB * _msbFactor) + pLSB)) / _measureIntervall;
        }

        private decimal CalculateWindSpeedMaximum(decimal pMSB, decimal pLSB)
        {
            return ((_mphFactor * _msFactor) * ((pMSB * _msbFactor) + pLSB)) / _measureIntervall;
        }

        private decimal CalculateTemperature(decimal pMSB, decimal pLSB)
        {
            return ((((pMSB * _msbFactor) + pLSB) * 0.024414M) - 40);
        }

        private decimal CalculateBatteryVoltage(decimal pMSB, decimal pLSB)
        {
            return (100M / 4096M) * ((pMSB * _msbFactor) + pLSB);
        }

        public void Reset()
        {
            _measures.Clear();
        }
    }
}
