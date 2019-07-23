namespace Oef6_5_InhoudZwembad
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
            this.inhoudLabel = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.diepLabel = new System.Windows.Forms.Label();
            this.diepTrackBar = new System.Windows.Forms.TrackBar();
            this.zwembadPictureBox = new System.Windows.Forms.PictureBox();
            this.ondiepLabel = new System.Windows.Forms.Label();
            this.ondiepTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.diepTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zwembadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ondiepTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // inhoudLabel
            // 
            this.inhoudLabel.Location = new System.Drawing.Point(226, 302);
            this.inhoudLabel.Name = "inhoudLabel";
            this.inhoudLabel.Size = new System.Drawing.Size(102, 40);
            this.inhoudLabel.TabIndex = 19;
            this.inhoudLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(150, 310);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(84, 24);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "inhoud";
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(150, 131);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(170, 24);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "dwarsdoorsnede";
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(30, 43);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(264, 56);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Zwembad";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(326, 49);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 32);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Breedte = 5m";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(326, 81);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 16);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Lengte = 20m";
            // 
            // diepLabel
            // 
            this.diepLabel.Location = new System.Drawing.Point(14, 291);
            this.diepLabel.Name = "diepLabel";
            this.diepLabel.Size = new System.Drawing.Size(88, 32);
            this.diepLabel.TabIndex = 12;
            // 
            // diepTrackBar
            // 
            this.diepTrackBar.Location = new System.Drawing.Point(46, 171);
            this.diepTrackBar.Maximum = 0;
            this.diepTrackBar.Minimum = -100;
            this.diepTrackBar.Name = "diepTrackBar";
            this.diepTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.diepTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.diepTrackBar.Size = new System.Drawing.Size(45, 120);
            this.diepTrackBar.TabIndex = 10;
            this.diepTrackBar.TickFrequency = 10;
            this.diepTrackBar.Value = -10;
            this.diepTrackBar.Scroll += new System.EventHandler(this.diepTrackBar_Scroll);
            // 
            // zwembadPictureBox
            // 
            this.zwembadPictureBox.Location = new System.Drawing.Point(110, 171);
            this.zwembadPictureBox.Name = "zwembadPictureBox";
            this.zwembadPictureBox.Size = new System.Drawing.Size(232, 112);
            this.zwembadPictureBox.TabIndex = 9;
            this.zwembadPictureBox.TabStop = false;
            // 
            // ondiepLabel
            // 
            this.ondiepLabel.Location = new System.Drawing.Point(333, 286);
            this.ondiepLabel.Name = "ondiepLabel";
            this.ondiepLabel.Size = new System.Drawing.Size(88, 32);
            this.ondiepLabel.TabIndex = 13;
            this.ondiepLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ondiepTrackBar
            // 
            this.ondiepTrackBar.Location = new System.Drawing.Point(358, 171);
            this.ondiepTrackBar.Maximum = 0;
            this.ondiepTrackBar.Minimum = -100;
            this.ondiepTrackBar.Name = "ondiepTrackBar";
            this.ondiepTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.ondiepTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ondiepTrackBar.Size = new System.Drawing.Size(45, 120);
            this.ondiepTrackBar.TabIndex = 11;
            this.ondiepTrackBar.TickFrequency = 10;
            this.ondiepTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.ondiepTrackBar.Value = -10;
            this.ondiepTrackBar.Scroll += new System.EventHandler(this.ondiepTrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 385);
            this.Controls.Add(this.inhoudLabel);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.diepLabel);
            this.Controls.Add(this.diepTrackBar);
            this.Controls.Add(this.zwembadPictureBox);
            this.Controls.Add(this.ondiepLabel);
            this.Controls.Add(this.ondiepTrackBar);
            this.Name = "Form1";
            this.Text = "Oef 6.5 Inhoud zwembad";
            ((System.ComponentModel.ISupportInitialize)(this.diepTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zwembadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ondiepTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label inhoudLabel;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label diepLabel;
        internal System.Windows.Forms.TrackBar diepTrackBar;
        internal System.Windows.Forms.PictureBox zwembadPictureBox;
        internal System.Windows.Forms.Label ondiepLabel;
        internal System.Windows.Forms.TrackBar ondiepTrackBar;
    }
}

