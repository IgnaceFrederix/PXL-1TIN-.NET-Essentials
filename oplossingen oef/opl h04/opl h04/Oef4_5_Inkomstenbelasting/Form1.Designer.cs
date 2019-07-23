namespace Oef4_5_Inkomstenbelasting
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
            this.inkomenTextBox = new System.Windows.Forms.TextBox();
            this.berekenButton = new System.Windows.Forms.Button();
            this.nettoLabel = new System.Windows.Forms.Label();
            this.belastingLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inkomenTextBox
            // 
            this.inkomenTextBox.Location = new System.Drawing.Point(121, 18);
            this.inkomenTextBox.Name = "inkomenTextBox";
            this.inkomenTextBox.Size = new System.Drawing.Size(100, 20);
            this.inkomenTextBox.TabIndex = 8;
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(121, 60);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(97, 24);
            this.berekenButton.TabIndex = 13;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // nettoLabel
            // 
            this.nettoLabel.BackColor = System.Drawing.SystemColors.Info;
            this.nettoLabel.Location = new System.Drawing.Point(118, 154);
            this.nettoLabel.Name = "nettoLabel";
            this.nettoLabel.Size = new System.Drawing.Size(100, 23);
            this.nettoLabel.TabIndex = 12;
            this.nettoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // belastingLabel
            // 
            this.belastingLabel.BackColor = System.Drawing.SystemColors.Info;
            this.belastingLabel.Location = new System.Drawing.Point(118, 114);
            this.belastingLabel.Name = "belastingLabel";
            this.belastingLabel.Size = new System.Drawing.Size(100, 23);
            this.belastingLabel.TabIndex = 11;
            this.belastingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Netto inkomen:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Belasting (20%):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inkomen:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 206);
            this.Controls.Add(this.inkomenTextBox);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.nettoLabel);
            this.Controls.Add(this.belastingLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Oef 4.5 Belasting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox inkomenTextBox;
        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.Label nettoLabel;
        internal System.Windows.Forms.Label belastingLabel;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
    }
}

