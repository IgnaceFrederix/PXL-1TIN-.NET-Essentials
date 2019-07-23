namespace Oef14_21_22_23_Zoekmethoden
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
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.zoek3Button = new System.Windows.Forms.Button();
            this.zoek2Button = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.zoekButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(350, 108);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(25, 13);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "(list)";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(350, 65);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(36, 13);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "(array)";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(350, 26);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(58, 13);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "(dictionary)";
            // 
            // zoek3Button
            // 
            this.zoek3Button.Location = new System.Drawing.Point(282, 102);
            this.zoek3Button.Name = "zoek3Button";
            this.zoek3Button.Size = new System.Drawing.Size(55, 24);
            this.zoek3Button.TabIndex = 14;
            this.zoek3Button.Text = "Zoek3!";
            this.zoek3Button.Click += new System.EventHandler(this.zoek3Button_Click);
            // 
            // zoek2Button
            // 
            this.zoek2Button.Location = new System.Drawing.Point(282, 59);
            this.zoek2Button.Name = "zoek2Button";
            this.zoek2Button.Size = new System.Drawing.Size(55, 24);
            this.zoek2Button.TabIndex = 13;
            this.zoek2Button.Text = "Zoek2!";
            this.zoek2Button.Click += new System.EventHandler(this.zoek2Button_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 147);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(325, 80);
            this.resultTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sleutel:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(68, 23);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(208, 20);
            this.keyTextBox.TabIndex = 10;
            this.keyTextBox.Text = "Vak999999";
            // 
            // zoekButton
            // 
            this.zoekButton.Location = new System.Drawing.Point(282, 20);
            this.zoekButton.Name = "zoekButton";
            this.zoekButton.Size = new System.Drawing.Size(55, 24);
            this.zoekButton.TabIndex = 9;
            this.zoekButton.Text = "Zoek!";
            this.zoekButton.Click += new System.EventHandler(this.zoekButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 239);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.zoek3Button);
            this.Controls.Add(this.zoek2Button);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.zoekButton);
            this.Name = "Form1";
            this.Text = "Oef 14.23 Duur zoekmethoden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button zoek3Button;
        internal System.Windows.Forms.Button zoek2Button;
        internal System.Windows.Forms.TextBox resultTextBox;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox keyTextBox;
        internal System.Windows.Forms.Button zoekButton;
    }
}

