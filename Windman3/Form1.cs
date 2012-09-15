using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace Windman3
{
    public partial class Form1 : Form
    {
        MeasureManager _measureManager;
        SerialPortManager _spManager;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _measureManager = new MeasureManager();
            _spManager = new SerialPortManager(_measureManager);
            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            _spManager.StartListening();
        }

        void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e)
        {
            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }

            _measureManager.Add(e.Data);
            if (_measureManager.IsReady)
            {
                if (_measureManager.CurrentMeasure != null)
                {
                    textBox1.Text += _measureManager.CurrentMeasure.WindDirection.ToString() + " | .";
                }
            }

            
            //if (e.Data[0] == 35)
            //{
            //    decimal decMSB = decimal.Parse(e.Data[50].ToString());
            //    decimal decLSB = decimal.Parse(e.Data[51].ToString());

            //    decimal res = 0.0878906m * ((decMSB * 256) + decLSB);
            //    textBox1.Text += ((int)res).ToString();
            //}
            //else
            //    textBox1.Text += " | ";

        }
    }
}
