namespace Windman3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLastMeasure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWindSpeedAverage = new System.Windows.Forms.Label();
            this.lblWindSpeedMinimum = new System.Windows.Forms.Label();
            this.lblWindSpeedMaximum = new System.Windows.Forms.Label();
            this.lblWindDirection = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblBatteryVoltage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Siste måling:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 198);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 71);
            this.textBox1.TabIndex = 1;
            // 
            // lblLastMeasure
            // 
            this.lblLastMeasure.AutoSize = true;
            this.lblLastMeasure.Location = new System.Drawing.Point(167, 19);
            this.lblLastMeasure.Name = "lblLastMeasure";
            this.lblLastMeasure.Size = new System.Drawing.Size(91, 13);
            this.lblLastMeasure.TabIndex = 2;
            this.lblLastMeasure.Text = "01.01.2012 13:13";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vindstyrke gjennomsnitt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vindstyrke minimum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vindstyrke maximum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vindretning:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Temperatur:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Batterispenning:";
            // 
            // lblWindSpeedAverage
            // 
            this.lblWindSpeedAverage.AutoSize = true;
            this.lblWindSpeedAverage.Location = new System.Drawing.Point(167, 41);
            this.lblWindSpeedAverage.Name = "lblWindSpeedAverage";
            this.lblWindSpeedAverage.Size = new System.Drawing.Size(91, 13);
            this.lblWindSpeedAverage.TabIndex = 9;
            this.lblWindSpeedAverage.Text = "01.01.2012 13:13";
            // 
            // lblWindSpeedMinimum
            // 
            this.lblWindSpeedMinimum.AutoSize = true;
            this.lblWindSpeedMinimum.Location = new System.Drawing.Point(167, 64);
            this.lblWindSpeedMinimum.Name = "lblWindSpeedMinimum";
            this.lblWindSpeedMinimum.Size = new System.Drawing.Size(91, 13);
            this.lblWindSpeedMinimum.TabIndex = 10;
            this.lblWindSpeedMinimum.Text = "01.01.2012 13:13";
            // 
            // lblWindSpeedMaximum
            // 
            this.lblWindSpeedMaximum.AutoSize = true;
            this.lblWindSpeedMaximum.Location = new System.Drawing.Point(167, 86);
            this.lblWindSpeedMaximum.Name = "lblWindSpeedMaximum";
            this.lblWindSpeedMaximum.Size = new System.Drawing.Size(91, 13);
            this.lblWindSpeedMaximum.TabIndex = 11;
            this.lblWindSpeedMaximum.Text = "01.01.2012 13:13";
            // 
            // lblWindDirection
            // 
            this.lblWindDirection.AutoSize = true;
            this.lblWindDirection.Location = new System.Drawing.Point(167, 112);
            this.lblWindDirection.Name = "lblWindDirection";
            this.lblWindDirection.Size = new System.Drawing.Size(91, 13);
            this.lblWindDirection.TabIndex = 12;
            this.lblWindDirection.Text = "01.01.2012 13:13";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(167, 135);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(91, 13);
            this.lblTemperature.TabIndex = 13;
            this.lblTemperature.Text = "01.01.2012 13:13";
            // 
            // lblBatteryVoltage
            // 
            this.lblBatteryVoltage.AutoSize = true;
            this.lblBatteryVoltage.Location = new System.Drawing.Point(167, 163);
            this.lblBatteryVoltage.Name = "lblBatteryVoltage";
            this.lblBatteryVoltage.Size = new System.Drawing.Size(91, 13);
            this.lblBatteryVoltage.TabIndex = 14;
            this.lblBatteryVoltage.Text = "01.01.2012 13:13";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 281);
            this.Controls.Add(this.lblBatteryVoltage);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblWindDirection);
            this.Controls.Add(this.lblWindSpeedMaximum);
            this.Controls.Add(this.lblWindSpeedMinimum);
            this.Controls.Add(this.lblWindSpeedAverage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLastMeasure);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblLastMeasure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWindSpeedAverage;
        private System.Windows.Forms.Label lblWindSpeedMinimum;
        private System.Windows.Forms.Label lblWindSpeedMaximum;
        private System.Windows.Forms.Label lblWindDirection;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblBatteryVoltage;
    }
}

