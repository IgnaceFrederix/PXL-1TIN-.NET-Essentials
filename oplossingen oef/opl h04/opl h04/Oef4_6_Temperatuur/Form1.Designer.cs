namespace Oef4_6_Temperatuur
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
            this.celsiusLabel = new System.Windows.Forms.Label();
            this.fahrenheitTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // celsiusLabel
            // 
            this.celsiusLabel.BackColor = System.Drawing.SystemColors.Info;
            this.celsiusLabel.Location = new System.Drawing.Point(132, 71);
            this.celsiusLabel.Name = "celsiusLabel";
            this.celsiusLabel.Size = new System.Drawing.Size(100, 23);
            this.celsiusLabel.TabIndex = 8;
            this.celsiusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fahrenheitTextbox
            // 
            this.fahrenheitTextbox.Location = new System.Drawing.Point(132, 29);
            this.fahrenheitTextbox.Name = "fahrenheitTextbox";
            this.fahrenheitTextbox.Size = new System.Drawing.Size(100, 20);
            this.fahrenheitTextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Graden Celsius";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Graden Fahrenheit";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(132, 126);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 4;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 166);
            this.Controls.Add(this.celsiusLabel);
            this.Controls.Add(this.fahrenheitTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.berekenButton);
            this.Name = "Form1";
            this.Text = "Oef 4.6 Temperatuur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label celsiusLabel;
        internal System.Windows.Forms.TextBox fahrenheitTextbox;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button berekenButton;
    }
}

