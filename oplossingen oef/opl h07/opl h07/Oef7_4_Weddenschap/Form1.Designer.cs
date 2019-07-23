namespace Oef7_4_Weddenschap
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
            this.Label4 = new System.Windows.Forms.Label();
            this.worpenProgressBar = new System.Windows.Forms.ProgressBar();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.stopLabel = new System.Windows.Forms.Button();
            this.getal3Label = new System.Windows.Forms.Label();
            this.getal2Label = new System.Windows.Forms.Label();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.getal1Label = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(14, 232);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 13);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Worpen:";
            // 
            // worpenProgressBar
            // 
            this.worpenProgressBar.Location = new System.Drawing.Point(65, 228);
            this.worpenProgressBar.Maximum = 20;
            this.worpenProgressBar.Name = "worpenProgressBar";
            this.worpenProgressBar.Size = new System.Drawing.Size(206, 23);
            this.worpenProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.worpenProgressBar.TabIndex = 22;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(52, 193);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 24);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "Total:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(98, 192);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(16, 23);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "€";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(98, 153);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(16, 23);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "€";
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalLabel.Location = new System.Drawing.Point(114, 188);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(32, 23);
            this.totalLabel.TabIndex = 18;
            this.totalLabel.Text = "0";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultLabel.Location = new System.Drawing.Point(114, 148);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(32, 23);
            this.resultLabel.TabIndex = 17;
            this.resultLabel.Text = "0";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopLabel
            // 
            this.stopLabel.Location = new System.Drawing.Point(98, 108);
            this.stopLabel.Name = "stopLabel";
            this.stopLabel.Size = new System.Drawing.Size(75, 23);
            this.stopLabel.TabIndex = 16;
            this.stopLabel.Text = "&Stop";
            this.stopLabel.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // getal3Label
            // 
            this.getal3Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.getal3Label.Location = new System.Drawing.Point(162, 60);
            this.getal3Label.Name = "getal3Label";
            this.getal3Label.Size = new System.Drawing.Size(40, 23);
            this.getal3Label.TabIndex = 15;
            this.getal3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getal2Label
            // 
            this.getal2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.getal2Label.Location = new System.Drawing.Point(114, 60);
            this.getal2Label.Name = "getal2Label";
            this.getal2Label.Size = new System.Drawing.Size(40, 23);
            this.getal2Label.TabIndex = 14;
            this.getal2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTimer
            // 
            this.startTimer.Interval = 10;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // getal1Label
            // 
            this.getal1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.getal1Label.Location = new System.Drawing.Point(66, 60);
            this.getal1Label.Name = "getal1Label";
            this.getal1Label.Size = new System.Drawing.Size(40, 23);
            this.getal1Label.TabIndex = 13;
            this.getal1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(98, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "&Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.worpenProgressBar);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.stopLabel);
            this.Controls.Add(this.getal3Label);
            this.Controls.Add(this.getal2Label);
            this.Controls.Add(this.getal1Label);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Oef 7.4 Weddenschap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ProgressBar worpenProgressBar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label totalLabel;
        internal System.Windows.Forms.Label resultLabel;
        internal System.Windows.Forms.Button stopLabel;
        internal System.Windows.Forms.Label getal3Label;
        internal System.Windows.Forms.Label getal2Label;
        internal System.Windows.Forms.Timer startTimer;
        internal System.Windows.Forms.Label getal1Label;
        internal System.Windows.Forms.Button startButton;
    }
}

