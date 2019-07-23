namespace Oef20_1_Balloon
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
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.radiusTrackBar = new System.Windows.Forms.TrackBar();
            this.balloonPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.Location = new System.Drawing.Point(74, 21);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(24, 24);
            this.RadiusLabel.TabIndex = 11;
            this.RadiusLabel.Text = "0";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(10, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 24);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "radius  =";
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(34, 156);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(48, 25);
            this.downButton.TabIndex = 9;
            this.downButton.Text = "Down";
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(34, 109);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(48, 24);
            this.upButton.TabIndex = 8;
            this.upButton.Text = "Up";
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // radiusTrackBar
            // 
            this.radiusTrackBar.Location = new System.Drawing.Point(106, 13);
            this.radiusTrackBar.Maximum = 100;
            this.radiusTrackBar.Name = "radiusTrackBar";
            this.radiusTrackBar.Size = new System.Drawing.Size(144, 45);
            this.radiusTrackBar.TabIndex = 7;
            this.radiusTrackBar.Scroll += new System.EventHandler(this.radiusTrackBar_Scroll);
            // 
            // balloonPictureBox
            // 
            this.balloonPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.balloonPictureBox.Location = new System.Drawing.Point(98, 69);
            this.balloonPictureBox.Name = "balloonPictureBox";
            this.balloonPictureBox.Size = new System.Drawing.Size(160, 168);
            this.balloonPictureBox.TabIndex = 6;
            this.balloonPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 275);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.radiusTrackBar);
            this.Controls.Add(this.balloonPictureBox);
            this.Name = "Form1";
            this.Text = "Oef 20.1 Balloon";
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balloonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label RadiusLabel;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button downButton;
        internal System.Windows.Forms.Button upButton;
        internal System.Windows.Forms.TrackBar radiusTrackBar;
        internal System.Windows.Forms.PictureBox balloonPictureBox;
    }
}

