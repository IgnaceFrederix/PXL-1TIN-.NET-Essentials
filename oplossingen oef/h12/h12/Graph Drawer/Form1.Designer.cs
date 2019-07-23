namespace Graph_Drawer
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
            this.aLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.cTrackBar = new System.Windows.Forms.TrackBar();
            this.aTrackBar = new System.Windows.Forms.TrackBar();
            this.bTrackBar = new System.Windows.Forms.TrackBar();
            this.dTrackBar = new System.Windows.Forms.TrackBar();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(12, 11);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(25, 13);
            this.aLabel.TabIndex = 0;
            this.aLabel.Text = "a = ";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(12, 55);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(25, 13);
            this.cLabel.TabIndex = 0;
            this.cLabel.Text = "c = ";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(147, 11);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(25, 13);
            this.bLabel.TabIndex = 0;
            this.bLabel.Text = "b = ";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(147, 55);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(25, 13);
            this.dLabel.TabIndex = 0;
            this.dLabel.Text = "d = ";
            // 
            // cTrackBar
            // 
            this.cTrackBar.Location = new System.Drawing.Point(43, 55);
            this.cTrackBar.Maximum = 5;
            this.cTrackBar.Minimum = -5;
            this.cTrackBar.Name = "cTrackBar";
            this.cTrackBar.Size = new System.Drawing.Size(82, 45);
            this.cTrackBar.TabIndex = 1;
            // 
            // aTrackBar
            // 
            this.aTrackBar.Location = new System.Drawing.Point(43, 11);
            this.aTrackBar.Maximum = 5;
            this.aTrackBar.Minimum = -5;
            this.aTrackBar.Name = "aTrackBar";
            this.aTrackBar.Size = new System.Drawing.Size(82, 45);
            this.aTrackBar.TabIndex = 1;
            // 
            // bTrackBar
            // 
            this.bTrackBar.Location = new System.Drawing.Point(178, 11);
            this.bTrackBar.Maximum = 5;
            this.bTrackBar.Minimum = -5;
            this.bTrackBar.Name = "bTrackBar";
            this.bTrackBar.Size = new System.Drawing.Size(82, 45);
            this.bTrackBar.TabIndex = 1;
            // 
            // dTrackBar
            // 
            this.dTrackBar.Location = new System.Drawing.Point(178, 55);
            this.dTrackBar.Maximum = 5;
            this.dTrackBar.Minimum = -5;
            this.dTrackBar.Name = "dTrackBar";
            this.dTrackBar.Size = new System.Drawing.Size(82, 45);
            this.dTrackBar.TabIndex = 1;
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.BackColor = System.Drawing.Color.White;
            this.graphPictureBox.Location = new System.Drawing.Point(12, 109);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(264, 224);
            this.graphPictureBox.TabIndex = 9;
            this.graphPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(291, 350);
            this.Controls.Add(this.graphPictureBox);
            this.Controls.Add(this.dTrackBar);
            this.Controls.Add(this.bTrackBar);
            this.Controls.Add(this.aTrackBar);
            this.Controls.Add(this.cTrackBar);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.cLabel);
            this.Controls.Add(this.aLabel);
            this.Name = "Form1";
            this.Text = "Graph drawer";
            ((System.ComponentModel.ISupportInitialize)(this.cTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.TrackBar cTrackBar;
        private System.Windows.Forms.TrackBar aTrackBar;
        private System.Windows.Forms.TrackBar bTrackBar;
        private System.Windows.Forms.TrackBar dTrackBar;
        internal System.Windows.Forms.PictureBox graphPictureBox;
    }
}

