namespace Oef17_3_OppDriehoek
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
            this.oppLabel = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oppLabel
            // 
            this.oppLabel.Location = new System.Drawing.Point(8, 208);
            this.oppLabel.Name = "oppLabel";
            this.oppLabel.Size = new System.Drawing.Size(268, 23);
            this.oppLabel.TabIndex = 15;
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(172, 96);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(56, 20);
            this.cTextBox.TabIndex = 12;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(172, 64);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(56, 20);
            this.bTextBox.TabIndex = 10;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(172, 32);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(56, 20);
            this.aTextBox.TabIndex = 9;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(28, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(136, 23);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Lengte C:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(28, 64);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(136, 23);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Lengte B:";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(92, 152);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 13;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(28, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 23);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Lengte A:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.oppLabel);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 17.3 Oppervlakte driehoek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label oppLabel;
        internal System.Windows.Forms.TextBox cTextBox;
        internal System.Windows.Forms.TextBox bTextBox;
        internal System.Windows.Forms.TextBox aTextBox;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.Label Label1;
    }
}

