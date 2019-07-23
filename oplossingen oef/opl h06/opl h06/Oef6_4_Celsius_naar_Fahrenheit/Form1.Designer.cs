namespace Oef6_4_Celsius_naar_Fahrenheit
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
            this.celsiusTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tempPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.celsiusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // celsiusTrackBar
            // 
            this.celsiusTrackBar.Location = new System.Drawing.Point(65, 30);
            this.celsiusTrackBar.Maximum = 100;
            this.celsiusTrackBar.Name = "celsiusTrackBar";
            this.celsiusTrackBar.Size = new System.Drawing.Size(280, 45);
            this.celsiusTrackBar.TabIndex = 11;
            this.celsiusTrackBar.TickFrequency = 10;
            this.celsiusTrackBar.Scroll += new System.EventHandler(this.celsiusTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Celsius:";
            // 
            // tempPictureBox
            // 
            this.tempPictureBox.Location = new System.Drawing.Point(65, 81);
            this.tempPictureBox.Name = "tempPictureBox";
            this.tempPictureBox.Size = new System.Drawing.Size(280, 118);
            this.tempPictureBox.TabIndex = 12;
            this.tempPictureBox.TabStop = false;
            this.tempPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.tempPictureBox_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 222);
            this.Controls.Add(this.tempPictureBox);
            this.Controls.Add(this.celsiusTrackBar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Oef 6.4 Celsius naar Fahrenheit";
            ((System.ComponentModel.ISupportInitialize)(this.celsiusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TrackBar celsiusTrackBar;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox tempPictureBox;

    }
}

