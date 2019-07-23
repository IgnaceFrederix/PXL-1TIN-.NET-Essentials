namespace Oef12_12_Grafieken
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
            this.verticalTrackBar = new System.Windows.Forms.TrackBar();
            this.horizontalTrackBar = new System.Windows.Forms.TrackBar();
            this.tekenButton = new System.Windows.Forms.Button();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Labeld = new System.Windows.Forms.Label();
            this.Labelb = new System.Windows.Forms.Label();
            this.Labelc = new System.Windows.Forms.Label();
            this.Labela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.verticalTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // verticalTrackBar
            // 
            this.verticalTrackBar.Location = new System.Drawing.Point(288, 100);
            this.verticalTrackBar.Minimum = 1;
            this.verticalTrackBar.Name = "verticalTrackBar";
            this.verticalTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.verticalTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.verticalTrackBar.Size = new System.Drawing.Size(45, 224);
            this.verticalTrackBar.TabIndex = 24;
            this.verticalTrackBar.Value = 10;
            this.verticalTrackBar.Scroll += new System.EventHandler(this.btnTeken_Click);
            // 
            // horizontalTrackBar
            // 
            this.horizontalTrackBar.Location = new System.Drawing.Point(18, 330);
            this.horizontalTrackBar.Minimum = 1;
            this.horizontalTrackBar.Name = "horizontalTrackBar";
            this.horizontalTrackBar.Size = new System.Drawing.Size(264, 45);
            this.horizontalTrackBar.TabIndex = 23;
            this.horizontalTrackBar.Value = 1;
            this.horizontalTrackBar.Scroll += new System.EventHandler(this.btnTeken_Click);
            // 
            // tekenButton
            // 
            this.tekenButton.Location = new System.Drawing.Point(224, 33);
            this.tekenButton.Name = "tekenButton";
            this.tekenButton.Size = new System.Drawing.Size(58, 23);
            this.tekenButton.TabIndex = 19;
            this.tekenButton.Text = "Teken";
            this.tekenButton.UseVisualStyleBackColor = true;
            this.tekenButton.Click += new System.EventHandler(this.btnTeken_Click);
            // 
            // dTextBox
            // 
            this.dTextBox.Location = new System.Drawing.Point(151, 57);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(48, 20);
            this.dTextBox.TabIndex = 18;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(151, 16);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(48, 20);
            this.bTextBox.TabIndex = 15;
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(47, 57);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(48, 20);
            this.cTextBox.TabIndex = 17;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(47, 17);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(48, 20);
            this.aTextBox.TabIndex = 13;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.PictureBox1.Location = new System.Drawing.Point(18, 100);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(264, 224);
            this.PictureBox1.TabIndex = 22;
            this.PictureBox1.TabStop = false;
            // 
            // Labeld
            // 
            this.Labeld.Location = new System.Drawing.Point(124, 60);
            this.Labeld.Name = "Labeld";
            this.Labeld.Size = new System.Drawing.Size(40, 24);
            this.Labeld.TabIndex = 21;
            this.Labeld.Text = "d =";
            // 
            // Labelb
            // 
            this.Labelb.Location = new System.Drawing.Point(124, 20);
            this.Labelb.Name = "Labelb";
            this.Labelb.Size = new System.Drawing.Size(40, 24);
            this.Labelb.TabIndex = 20;
            this.Labelb.Text = "b =";
            // 
            // Labelc
            // 
            this.Labelc.Location = new System.Drawing.Point(18, 60);
            this.Labelc.Name = "Labelc";
            this.Labelc.Size = new System.Drawing.Size(40, 24);
            this.Labelc.TabIndex = 16;
            this.Labelc.Text = "c =";
            // 
            // Labela
            // 
            this.Labela.Location = new System.Drawing.Point(18, 20);
            this.Labela.Name = "Labela";
            this.Labela.Size = new System.Drawing.Size(40, 24);
            this.Labela.TabIndex = 14;
            this.Labela.Text = "a =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 380);
            this.Controls.Add(this.verticalTrackBar);
            this.Controls.Add(this.horizontalTrackBar);
            this.Controls.Add(this.tekenButton);
            this.Controls.Add(this.dTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Labeld);
            this.Controls.Add(this.Labelb);
            this.Controls.Add(this.Labelc);
            this.Controls.Add(this.Labela);
            this.Name = "Form1";
            this.Text = "Oef 12.12 Grafieken";
            ((System.ComponentModel.ISupportInitialize)(this.verticalTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TrackBar verticalTrackBar;
        internal System.Windows.Forms.TrackBar horizontalTrackBar;
        internal System.Windows.Forms.Button tekenButton;
        internal System.Windows.Forms.TextBox dTextBox;
        internal System.Windows.Forms.TextBox bTextBox;
        internal System.Windows.Forms.TextBox cTextBox;
        internal System.Windows.Forms.TextBox aTextBox;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Labeld;
        internal System.Windows.Forms.Label Labelb;
        internal System.Windows.Forms.Label Labelc;
        internal System.Windows.Forms.Label Labela;
    }
}

