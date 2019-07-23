namespace Oef4_2_OmtrOppVol_Bol
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
            this.volumeLabel = new System.Windows.Forms.Label();
            this.oppLabel = new System.Windows.Forms.Label();
            this.omtrekLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.straalTextbox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // volumeLabel
            // 
            this.volumeLabel.BackColor = System.Drawing.SystemColors.Info;
            this.volumeLabel.Location = new System.Drawing.Point(126, 184);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(104, 23);
            this.volumeLabel.TabIndex = 17;
            this.volumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oppLabel
            // 
            this.oppLabel.BackColor = System.Drawing.SystemColors.Info;
            this.oppLabel.Location = new System.Drawing.Point(126, 156);
            this.oppLabel.Name = "oppLabel";
            this.oppLabel.Size = new System.Drawing.Size(104, 23);
            this.oppLabel.TabIndex = 16;
            this.oppLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // omtrekLabel
            // 
            this.omtrekLabel.BackColor = System.Drawing.SystemColors.Info;
            this.omtrekLabel.Location = new System.Drawing.Point(126, 128);
            this.omtrekLabel.Name = "omtrekLabel";
            this.omtrekLabel.Size = new System.Drawing.Size(104, 23);
            this.omtrekLabel.TabIndex = 15;
            this.omtrekLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(54, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Volume:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(54, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Oppervlakte:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(54, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Omtrek:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Geef straal:";
            // 
            // straalTextbox
            // 
            this.straalTextbox.Location = new System.Drawing.Point(124, 24);
            this.straalTextbox.Name = "straalTextbox";
            this.straalTextbox.Size = new System.Drawing.Size(100, 20);
            this.straalTextbox.TabIndex = 9;
            // 
            // calcButton
            // 
            this.calcButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calcButton.Location = new System.Drawing.Point(124, 67);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 23);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "&Bereken";
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 238);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.oppLabel);
            this.Controls.Add(this.omtrekLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.straalTextbox);
            this.Controls.Add(this.calcButton);
            this.Name = "Form1";
            this.Text = "Oef 4.2 Bol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label volumeLabel;
        internal System.Windows.Forms.Label oppLabel;
        internal System.Windows.Forms.Label omtrekLabel;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox straalTextbox;
        internal System.Windows.Forms.Button calcButton;
    }
}

