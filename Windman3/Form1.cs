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
        VindsidenCommunication _vsComm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblLastMeasure.Text = "";
            lblLastMeasure.Text = "";
            lblTemperature.Text = "";
            lblWindDirection.Text = "";
            lblWindSpeedAverage.Text = "";
            lblWindSpeedMaximum.Text = "";
            lblWindSpeedMinimum.Text = "";
            lblBatteryVoltage.Text = "";

            _vsComm = new VindsidenCommunication();
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
                    lblLastMeasure.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.CreateSpecificCulture("nb-NO"));
                    lblWindDirection.Text = _measureManager.CurrentMeasure.WindDirectionAsString;
                    lblWindSpeedAverage.Text = _measureManager.CurrentMeasure.WindSpeedAverageAsString;
                    lblWindMSB.Text = _measureManager.WindMSB;
                    lblWindLSB.Text = _measureManager.WindLSB;
                    lblWindMinMSB.Text = _measureManager.WindMinMSB;
                    lblWindMinLSB.Text = _measureManager.WindMinLSB;
                    lblWindMaxMSB.Text = _measureManager.WindMaxMSB;
                    lblWindMaxLSB.Text = _measureManager.WindMaxLSB;
                    lblWindSpeedMinimum.Text = _measureManager.CurrentMeasure.WindSpeedMinimumAsString;
                    lblWindSpeedMaximum.Text = _measureManager.CurrentMeasure.WindSpeedMaximumAsString;
                    lblWindDirection.Text = _measureManager.CurrentMeasure.WindDirectionAsString;
                    lblTemperature.Text = _measureManager.CurrentMeasure.TemperatureAsString;
                    lblBatteryVoltage.Text = _measureManager.CurrentMeasure.BatteryVoltageAsString;
                    //Send til Vindsiden.no
                    _vsComm.SendData(_measureManager.CurrentMeasure);
                }
            }
            _measureManager.Reset();
        }
    }
}
