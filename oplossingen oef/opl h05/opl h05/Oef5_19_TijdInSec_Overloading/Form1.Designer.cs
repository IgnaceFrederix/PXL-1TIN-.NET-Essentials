namespace Oef5_19_TijdInSec_Overloading
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
            this.secondenTextBox = new System.Windows.Forms.TextBox();
            this.minutenTextBox = new System.Windows.Forms.TextBox();
            this.urenTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.aantalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secondenTextBox
            // 
            this.secondenTextBox.Location = new System.Drawing.Point(88, 116);
            this.secondenTextBox.Name = "secondenTextBox";
            this.secondenTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondenTextBox.TabIndex = 13;
            // 
            // minutenTextBox
            // 
            this.minutenTextBox.Location = new System.Drawing.Point(88, 64);
            this.minutenTextBox.Name = "minutenTextBox";
            this.minutenTextBox.Size = new System.Drawing.Size(100, 20);
            this.minutenTextBox.TabIndex = 12;
            // 
            // urenTextBox
            // 
            this.urenTextBox.Location = new System.Drawing.Point(88, 12);
            this.urenTextBox.Name = "urenTextBox";
            this.urenTextBox.Size = new System.Drawing.Size(100, 20);
            this.urenTextBox.TabIndex = 11;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(18, 119);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Seconden:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Minuten:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(33, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Uren:";
            // 
            // aantalButton
            // 
            this.aantalButton.Location = new System.Drawing.Point(88, 190);
            this.aantalButton.Name = "aantalButton";
            this.aantalButton.Size = new System.Drawing.Size(100, 23);
            this.aantalButton.TabIndex = 7;
            this.aantalButton.Text = "Aantal seconden";
            this.aantalButton.Click += new System.EventHandler(this.aantalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 235);
            this.Controls.Add(this.secondenTextBox);
            this.Controls.Add(this.minutenTextBox);
            this.Controls.Add(this.urenTextBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.aantalButton);
            this.Name = "Form1";
            this.Text = "Oef 5.19 Tijd in seconden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox secondenTextBox;
        internal System.Windows.Forms.TextBox minutenTextBox;
        internal System.Windows.Forms.TextBox urenTextBox;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button aantalButton;
    }
}

