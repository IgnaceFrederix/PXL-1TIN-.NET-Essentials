namespace Oef5_1_ToonNaam
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
            this.voornaamTextBox = new System.Windows.Forms.TextBox();
            this.toonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(11, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 23);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Voornaam:";
            // 
            // voornaamTextBox
            // 
            this.voornaamTextBox.Location = new System.Drawing.Point(81, 9);
            this.voornaamTextBox.Name = "voornaamTextBox";
            this.voornaamTextBox.Size = new System.Drawing.Size(100, 20);
            this.voornaamTextBox.TabIndex = 4;
            // 
            // toonButton
            // 
            this.toonButton.Location = new System.Drawing.Point(106, 48);
            this.toonButton.Name = "toonButton";
            this.toonButton.Size = new System.Drawing.Size(75, 23);
            this.toonButton.TabIndex = 5;
            this.toonButton.Text = "Toon naam";
            this.toonButton.Click += new System.EventHandler(this.toonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 88);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.voornaamTextBox);
            this.Controls.Add(this.toonButton);
            this.Name = "Form1";
            this.Text = "Oef 5.1 Toon naam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox voornaamTextBox;
        internal System.Windows.Forms.Button toonButton;
    }
}

