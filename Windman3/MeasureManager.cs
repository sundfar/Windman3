using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Windman3
{
    public class MeasureManager
    {
        private int packetSize;
        //private byte[] _measureArray;
        private Measure _measure;
        private List<Measure> _measures;
        public bool IsReady { get; set; }


        public int PacketSize
        {
            get
            {
                return packetSize;
            }
        }


        public Measure CurrentMeasure
        {
            get 
            {
                //foreach (var item in _measures)
                //{
                //    return item;
                //}
                Measure averageMeasure = new Measure();
                averageMeasure.WindDirection = _measures.Average(m => m.WindDirection);
                return averageMeasure;
                //return null;
            }
        }

        public MeasureManager()
        {
            packetSize = Int32.Parse(ConfigurationManager.AppSettings["PacketSize"].ToString());
            IsReady = false;
            _measures = new List<Measure>();
            _measure = new Measure();
        }
        public void Add(byte[] pMeasure)
        {
            if (pMeasure.Length == packetSize)
            {
                Measure m = new Measure();
                m.WindDirection = CalculateWindDirection(decimal.Parse(pMeasure[50].ToString()), decimal.Parse(pMeasure[51].ToString()));

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

        private decimal CalculateWindDirection(decimal pMSB, decimal pLSB)
        {
            return (0.0878906m * ((pMSB * 256) + pLSB));
        }

        public void Reset()
        {
            _measures.Clear();
        }
    }
}
