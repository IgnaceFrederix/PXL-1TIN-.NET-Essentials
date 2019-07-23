namespace Boxes
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
            this.boxesPictureBox = new System.Windows.Forms.PictureBox();
            this.countTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.boxesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // boxesPictureBox
            // 
            this.boxesPictureBox.BackColor = System.Drawing.Color.White;
            this.boxesPictureBox.Location = new System.Drawing.Point(12, 98);
            this.boxesPictureBox.Name = "boxesPictureBox";
            this.boxesPictureBox.Size = new System.Drawing.Size(260, 50);
            this.boxesPictureBox.TabIndex = 0;
            this.boxesPictureBox.TabStop = false;
            // 
            // countTrackBar
            // 
            this.countTrackBar.Location = new System.Drawing.Point(12, 33);
            this.countTrackBar.Name = "countTrackBar";
            this.countTrackBar.Size = new System.Drawing.Size(260, 45);
            this.countTrackBar.TabIndex = 1;
            this.countTrackBar.Scroll += new System.EventHandler(this.countTrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(284, 170);
            this.Controls.Add(this.countTrackBar);
            this.Controls.Add(this.boxesPictureBox);
            this.Name = "Form1";
            this.Text = "Boxes";
            ((System.ComponentModel.ISupportInitialize)(this.boxesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boxesPictureBox;
        private System.Windows.Forms.TrackBar countTrackBar;
    }
}

