namespace Oef21_1_Kaartnummer
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
            this.methode4Button = new System.Windows.Forms.Button();
            this.methode3Button = new System.Windows.Forms.Button();
            this.methode2Button = new System.Windows.Forms.Button();
            this.methode1Button = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.nummerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // methode4Button
            // 
            this.methode4Button.Location = new System.Drawing.Point(21, 200);
            this.methode4Button.Name = "methode4Button";
            this.methode4Button.Size = new System.Drawing.Size(88, 23);
            this.methode4Button.TabIndex = 11;
            this.methode4Button.Text = "Kaart string 4";
            this.methode4Button.UseVisualStyleBackColor = true;
            this.methode4Button.Click += new System.EventHandler(this.methode4Button_Click);
            // 
            // methode3Button
            // 
            this.methode3Button.Location = new System.Drawing.Point(21, 154);
            this.methode3Button.Name = "methode3Button";
            this.methode3Button.Size = new System.Drawing.Size(88, 23);
            this.methode3Button.TabIndex = 10;
            this.methode3Button.Text = "Kaart string 3";
            this.methode3Button.UseVisualStyleBackColor = true;
            this.methode3Button.Click += new System.EventHandler(this.methode3Button_Click);
            // 
            // methode2Button
            // 
            this.methode2Button.Location = new System.Drawing.Point(21, 107);
            this.methode2Button.Name = "methode2Button";
            this.methode2Button.Size = new System.Drawing.Size(88, 23);
            this.methode2Button.TabIndex = 9;
            this.methode2Button.Text = "Kaart string 2";
            this.methode2Button.UseVisualStyleBackColor = true;
            this.methode2Button.Click += new System.EventHandler(this.methode2Button_Click);
            // 
            // methode1Button
            // 
            this.methode1Button.Location = new System.Drawing.Point(21, 60);
            this.methode1Button.Name = "methode1Button";
            this.methode1Button.Size = new System.Drawing.Size(88, 23);
            this.methode1Button.TabIndex = 8;
            this.methode1Button.Text = "Kaart string 1";
            this.methode1Button.UseVisualStyleBackColor = true;
            this.methode1Button.Click += new System.EventHandler(this.methode1Button_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Nummer:";
            // 
            // nummerTextBox
            // 
            this.nummerTextBox.Location = new System.Drawing.Point(78, 12);
            this.nummerTextBox.Name = "nummerTextBox";
            this.nummerTextBox.Size = new System.Drawing.Size(31, 20);
            this.nummerTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 244);
            this.Controls.Add(this.methode4Button);
            this.Controls.Add(this.methode3Button);
            this.Controls.Add(this.methode2Button);
            this.Controls.Add(this.methode1Button);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.nummerTextBox);
            this.Name = "Form1";
            this.Text = "Oef 21.1 Kaartnummer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button methode4Button;
        internal System.Windows.Forms.Button methode3Button;
        internal System.Windows.Forms.Button methode2Button;
        internal System.Windows.Forms.Button methode1Button;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox nummerTextBox;
    }
}

