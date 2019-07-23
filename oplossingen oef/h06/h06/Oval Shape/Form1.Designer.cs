namespace Oval_Shape
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horizTrackBar = new System.Windows.Forms.TrackBar();
            this.vertTrackBar = new System.Windows.Forms.TrackBar();
            this.horizLabel = new System.Windows.Forms.Label();
            this.vertLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(90, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // horizTrackBar
            // 
            this.horizTrackBar.Location = new System.Drawing.Point(90, 218);
            this.horizTrackBar.Name = "horizTrackBar";
            this.horizTrackBar.Size = new System.Drawing.Size(200, 45);
            this.horizTrackBar.TabIndex = 1;
            this.horizTrackBar.Scroll += new System.EventHandler(this.horizTrackBar_Scroll);
            // 
            // vertTrackBar
            // 
            this.vertTrackBar.Location = new System.Drawing.Point(39, 12);
            this.vertTrackBar.Name = "vertTrackBar";
            this.vertTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vertTrackBar.Size = new System.Drawing.Size(45, 200);
            this.vertTrackBar.TabIndex = 1;
            this.vertTrackBar.Scroll += new System.EventHandler(this.vertTrackBar_Scroll);
            // 
            // horizLabel
            // 
            this.horizLabel.AutoSize = true;
            this.horizLabel.Location = new System.Drawing.Point(165, 266);
            this.horizLabel.Name = "horizLabel";
            this.horizLabel.Size = new System.Drawing.Size(35, 13);
            this.horizLabel.TabIndex = 2;
            this.horizLabel.Text = "label1";
            // 
            // vertLabel
            // 
            this.vertLabel.AutoSize = true;
            this.vertLabel.Location = new System.Drawing.Point(8, 100);
            this.vertLabel.Name = "vertLabel";
            this.vertLabel.Size = new System.Drawing.Size(35, 13);
            this.vertLabel.TabIndex = 2;
            this.vertLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(308, 295);
            this.Controls.Add(this.vertLabel);
            this.Controls.Add(this.horizLabel);
            this.Controls.Add(this.vertTrackBar);
            this.Controls.Add(this.horizTrackBar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Oval Shape";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar horizTrackBar;
        private System.Windows.Forms.TrackBar vertTrackBar;
        private System.Windows.Forms.Label horizLabel;
        private System.Windows.Forms.Label vertLabel;
    }
}

