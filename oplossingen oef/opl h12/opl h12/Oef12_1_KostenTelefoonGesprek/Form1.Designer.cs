namespace Oef12_1_KostenTelefoonGesprek
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
            this.prijsLabel = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.secondenTextBox = new System.Windows.Forms.TextBox();
            this.minutenTextBox = new System.Windows.Forms.TextBox();
            this.urenTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prijsLabel
            // 
            this.prijsLabel.AutoSize = true;
            this.prijsLabel.Location = new System.Drawing.Point(105, 145);
            this.prijsLabel.Name = "prijsLabel";
            this.prijsLabel.Size = new System.Drawing.Size(39, 13);
            this.prijsLabel.TabIndex = 13;
            this.prijsLabel.Text = "Label5";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 145);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(90, 13);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Kostprijs gesprek:";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(226, 19);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 11;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.UseVisualStyleBackColor = true;
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // secondenTextBox
            // 
            this.secondenTextBox.Location = new System.Drawing.Point(98, 74);
            this.secondenTextBox.Name = "secondenTextBox";
            this.secondenTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondenTextBox.TabIndex = 10;
            // 
            // minutenTextBox
            // 
            this.minutenTextBox.Location = new System.Drawing.Point(98, 45);
            this.minutenTextBox.Name = "minutenTextBox";
            this.minutenTextBox.Size = new System.Drawing.Size(100, 20);
            this.minutenTextBox.TabIndex = 9;
            // 
            // urenTextBox
            // 
            this.urenTextBox.Location = new System.Drawing.Point(98, 19);
            this.urenTextBox.Name = "urenTextBox";
            this.urenTextBox.Size = new System.Drawing.Size(100, 20);
            this.urenTextBox.TabIndex = 8;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 77);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(59, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Seconden:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Minuten:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(33, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Uren:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 183);
            this.Controls.Add(this.prijsLabel);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.secondenTextBox);
            this.Controls.Add(this.minutenTextBox);
            this.Controls.Add(this.urenTextBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 12.1 Kosten telefoongesprek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label prijsLabel;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.TextBox secondenTextBox;
        internal System.Windows.Forms.TextBox minutenTextBox;
        internal System.Windows.Forms.TextBox urenTextBox;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

