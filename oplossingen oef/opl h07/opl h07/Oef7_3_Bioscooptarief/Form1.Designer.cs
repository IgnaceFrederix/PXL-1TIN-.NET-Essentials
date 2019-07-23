namespace Oef7_3_Bioscooptarief
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
            this.Label1 = new System.Windows.Forms.Label();
            this.leeftijdTextBox = new System.Windows.Forms.TextBox();
            this.berekenButton = new System.Windows.Forms.Button();
            this.tariefLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 23);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Leeftijd:";
            // 
            // leeftijdTextBox
            // 
            this.leeftijdTextBox.Location = new System.Drawing.Point(64, 12);
            this.leeftijdTextBox.Name = "leeftijdTextBox";
            this.leeftijdTextBox.Size = new System.Drawing.Size(104, 20);
            this.leeftijdTextBox.TabIndex = 3;
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(64, 52);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(104, 23);
            this.berekenButton.TabIndex = 4;
            this.berekenButton.Text = "&Bereken";
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // tariefLabel
            // 
            this.tariefLabel.Location = new System.Drawing.Point(61, 94);
            this.tariefLabel.Name = "tariefLabel";
            this.tariefLabel.Size = new System.Drawing.Size(100, 23);
            this.tariefLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 132);
            this.Controls.Add(this.tariefLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.leeftijdTextBox);
            this.Controls.Add(this.berekenButton);
            this.Name = "Form1";
            this.Text = "Oef 7.3 Bioscooptarief";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox leeftijdTextBox;
        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.Label tariefLabel;
    }
}

