namespace Oef7_10_SchildpadTekenen
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
            this.naarVoorButton = new System.Windows.Forms.Button();
            this.txtNaarvoor = new System.Windows.Forms.TextBox();
            this.naarRechtsButton = new System.Windows.Forms.Button();
            this.naarBenedenButton = new System.Windows.Forms.Button();
            this.naarLinksButton = new System.Windows.Forms.Button();
            this.naarBovenButton = new System.Windows.Forms.Button();
            this.schildpadPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.schildpadPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // naarVoorButton
            // 
            this.naarVoorButton.Location = new System.Drawing.Point(184, 435);
            this.naarVoorButton.Name = "naarVoorButton";
            this.naarVoorButton.Size = new System.Drawing.Size(75, 23);
            this.naarVoorButton.TabIndex = 13;
            this.naarVoorButton.Text = "Naar Voor";
            this.naarVoorButton.Click += new System.EventHandler(this.naarVoorButton_Click);
            // 
            // txtNaarvoor
            // 
            this.txtNaarvoor.Location = new System.Drawing.Point(24, 435);
            this.txtNaarvoor.Name = "txtNaarvoor";
            this.txtNaarvoor.Size = new System.Drawing.Size(144, 20);
            this.txtNaarvoor.TabIndex = 12;
            // 
            // naarRechtsButton
            // 
            this.naarRechtsButton.Location = new System.Drawing.Point(144, 499);
            this.naarRechtsButton.Name = "naarRechtsButton";
            this.naarRechtsButton.Size = new System.Drawing.Size(112, 48);
            this.naarRechtsButton.TabIndex = 11;
            this.naarRechtsButton.Text = "Draai 90° naar rechts";
            this.naarRechtsButton.Click += new System.EventHandler(this.naarRechtsButton_Click);
            // 
            // naarBenedenButton
            // 
            this.naarBenedenButton.Location = new System.Drawing.Point(144, 467);
            this.naarBenedenButton.Name = "naarBenedenButton";
            this.naarBenedenButton.Size = new System.Drawing.Size(112, 23);
            this.naarBenedenButton.TabIndex = 10;
            this.naarBenedenButton.Text = "Pen naar beneden";
            this.naarBenedenButton.Click += new System.EventHandler(this.naarBenedenButton_Click);
            // 
            // naarLinksButton
            // 
            this.naarLinksButton.Location = new System.Drawing.Point(24, 499);
            this.naarLinksButton.Name = "naarLinksButton";
            this.naarLinksButton.Size = new System.Drawing.Size(112, 48);
            this.naarLinksButton.TabIndex = 9;
            this.naarLinksButton.Text = "Draai 90° naar links";
            this.naarLinksButton.Click += new System.EventHandler(this.naarLinksButton_Click);
            // 
            // naarBovenButton
            // 
            this.naarBovenButton.Location = new System.Drawing.Point(24, 467);
            this.naarBovenButton.Name = "naarBovenButton";
            this.naarBovenButton.Size = new System.Drawing.Size(112, 24);
            this.naarBovenButton.TabIndex = 8;
            this.naarBovenButton.Text = "Pen naar boven";
            this.naarBovenButton.Click += new System.EventHandler(this.naarBovenButton_Click);
            // 
            // schildpadPictureBox
            // 
            this.schildpadPictureBox.Location = new System.Drawing.Point(32, 19);
            this.schildpadPictureBox.Name = "schildpadPictureBox";
            this.schildpadPictureBox.Size = new System.Drawing.Size(432, 360);
            this.schildpadPictureBox.TabIndex = 7;
            this.schildpadPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 566);
            this.Controls.Add(this.naarVoorButton);
            this.Controls.Add(this.txtNaarvoor);
            this.Controls.Add(this.naarRechtsButton);
            this.Controls.Add(this.naarBenedenButton);
            this.Controls.Add(this.naarLinksButton);
            this.Controls.Add(this.naarBovenButton);
            this.Controls.Add(this.schildpadPictureBox);
            this.Name = "Form1";
            this.Text = "Oef 7.10 Schildpadtekenen";
            ((System.ComponentModel.ISupportInitialize)(this.schildpadPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button naarVoorButton;
        internal System.Windows.Forms.TextBox txtNaarvoor;
        internal System.Windows.Forms.Button naarRechtsButton;
        internal System.Windows.Forms.Button naarBenedenButton;
        internal System.Windows.Forms.Button naarLinksButton;
        internal System.Windows.Forms.Button naarBovenButton;
        internal System.Windows.Forms.PictureBox schildpadPictureBox;
    }
}

