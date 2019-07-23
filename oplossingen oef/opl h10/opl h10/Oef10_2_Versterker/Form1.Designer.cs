namespace Oef10_2_Versterker
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
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.versterkerTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.versterkerTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(11, 175);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(40, 23);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Max:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(11, 135);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 23);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Min:";
            // 
            // maxLabel
            // 
            this.maxLabel.Location = new System.Drawing.Point(59, 175);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(48, 23);
            this.maxLabel.TabIndex = 9;
            this.maxLabel.Text = "Label3";
            // 
            // minLabel
            // 
            this.minLabel.Location = new System.Drawing.Point(59, 135);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(48, 23);
            this.minLabel.TabIndex = 8;
            this.minLabel.Text = "Label2";
            // 
            // valueLabel
            // 
            this.valueLabel.Location = new System.Drawing.Point(67, 71);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(48, 23);
            this.valueLabel.TabIndex = 7;
            this.valueLabel.Text = "Label1";
            // 
            // versterkerTrackBar
            // 
            this.versterkerTrackBar.Location = new System.Drawing.Point(19, 15);
            this.versterkerTrackBar.Name = "versterkerTrackBar";
            this.versterkerTrackBar.Size = new System.Drawing.Size(136, 45);
            this.versterkerTrackBar.TabIndex = 6;
            this.versterkerTrackBar.Scroll += new System.EventHandler(this.versterkerTrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 203);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.versterkerTrackBar);
            this.Name = "Form1";
            this.Text = "Oef 10.2 Versterker";
            ((System.ComponentModel.ISupportInitialize)(this.versterkerTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label maxLabel;
        internal System.Windows.Forms.Label minLabel;
        internal System.Windows.Forms.Label valueLabel;
        internal System.Windows.Forms.TrackBar versterkerTrackBar;
    }
}

