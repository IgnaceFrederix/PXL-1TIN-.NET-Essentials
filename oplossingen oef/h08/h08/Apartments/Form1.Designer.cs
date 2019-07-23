namespace Apartments
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
            this.apartmentsPictureBox = new System.Windows.Forms.PictureBox();
            this.horizTrackBar = new System.Windows.Forms.TrackBar();
            this.vertTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // apartmentsPictureBox
            // 
            this.apartmentsPictureBox.BackColor = System.Drawing.Color.White;
            this.apartmentsPictureBox.Location = new System.Drawing.Point(60, 60);
            this.apartmentsPictureBox.Name = "apartmentsPictureBox";
            this.apartmentsPictureBox.Size = new System.Drawing.Size(212, 181);
            this.apartmentsPictureBox.TabIndex = 0;
            this.apartmentsPictureBox.TabStop = false;
            // 
            // horizTrackBar
            // 
            this.horizTrackBar.Location = new System.Drawing.Point(60, 12);
            this.horizTrackBar.Name = "horizTrackBar";
            this.horizTrackBar.Size = new System.Drawing.Size(212, 45);
            this.horizTrackBar.TabIndex = 1;
            // 
            // vertTrackBar
            // 
            this.vertTrackBar.Location = new System.Drawing.Point(9, 60);
            this.vertTrackBar.Name = "vertTrackBar";
            this.vertTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vertTrackBar.Size = new System.Drawing.Size(45, 181);
            this.vertTrackBar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.vertTrackBar);
            this.Controls.Add(this.horizTrackBar);
            this.Controls.Add(this.apartmentsPictureBox);
            this.Name = "Form1";
            this.Text = "Apartments";
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox apartmentsPictureBox;
        private System.Windows.Forms.TrackBar horizTrackBar;
        private System.Windows.Forms.TrackBar vertTrackBar;
    }
}

