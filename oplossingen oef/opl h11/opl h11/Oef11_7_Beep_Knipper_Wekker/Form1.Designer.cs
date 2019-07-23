namespace Oef11_7_Beep_Knipper_Wekker
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
            this.components = new System.ComponentModel.Container();
            this.alarmTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.setButton = new System.Windows.Forms.Button();
            this.clockLabel = new System.Windows.Forms.Label();
            this.knipperRadioButton = new System.Windows.Forms.RadioButton();
            this.beepRadioButton = new System.Windows.Forms.RadioButton();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.alarmTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // alarmTextBox
            // 
            this.alarmTextBox.Location = new System.Drawing.Point(151, 107);
            this.alarmTextBox.Mask = "00:00";
            this.alarmTextBox.Name = "alarmTextBox";
            this.alarmTextBox.Size = new System.Drawing.Size(48, 20);
            this.alarmTextBox.TabIndex = 12;
            this.alarmTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(106, 110);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Alarmtijd";
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(205, 105);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 10;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // clockLabel
            // 
            this.clockLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.Location = new System.Drawing.Point(12, 18);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(268, 57);
            this.clockLabel.TabIndex = 9;
            this.clockLabel.Text = "HH:MM:SS";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // knipperRadioButton
            // 
            this.knipperRadioButton.AutoSize = true;
            this.knipperRadioButton.Checked = true;
            this.knipperRadioButton.Location = new System.Drawing.Point(16, 112);
            this.knipperRadioButton.Name = "knipperRadioButton";
            this.knipperRadioButton.Size = new System.Drawing.Size(61, 17);
            this.knipperRadioButton.TabIndex = 14;
            this.knipperRadioButton.TabStop = true;
            this.knipperRadioButton.Text = "Knipper";
            this.knipperRadioButton.UseVisualStyleBackColor = true;
            this.knipperRadioButton.CheckedChanged += new System.EventHandler(this.knipperRadioButton_CheckedChanged);
            // 
            // beepRadioButton
            // 
            this.beepRadioButton.AutoSize = true;
            this.beepRadioButton.Location = new System.Drawing.Point(16, 89);
            this.beepRadioButton.Name = "beepRadioButton";
            this.beepRadioButton.Size = new System.Drawing.Size(50, 17);
            this.beepRadioButton.TabIndex = 13;
            this.beepRadioButton.Text = "Beep";
            this.beepRadioButton.UseVisualStyleBackColor = true;
            this.beepRadioButton.CheckedChanged += new System.EventHandler(this.beepRadioButton_CheckedChanged);
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // alarmTimer
            // 
            this.alarmTimer.Interval = 300;
            this.alarmTimer.Tick += new System.EventHandler(this.alarmTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 153);
            this.Controls.Add(this.knipperRadioButton);
            this.Controls.Add(this.beepRadioButton);
            this.Controls.Add(this.alarmTextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.clockLabel);
            this.Name = "Form1";
            this.Text = "Oef 11.7 Beep en Knipper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox alarmTextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button setButton;
        internal System.Windows.Forms.Label clockLabel;
        internal System.Windows.Forms.RadioButton knipperRadioButton;
        internal System.Windows.Forms.RadioButton beepRadioButton;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Timer alarmTimer;
    }
}

