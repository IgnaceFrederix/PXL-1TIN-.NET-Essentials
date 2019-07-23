namespace Oef8_1_ToonGetallen
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
            this.machtenTextBox = new System.Windows.Forms.TextBox();
            this.toonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // machtenTextBox
            // 
            this.machtenTextBox.Location = new System.Drawing.Point(29, 60);
            this.machtenTextBox.Multiline = true;
            this.machtenTextBox.Name = "machtenTextBox";
            this.machtenTextBox.Size = new System.Drawing.Size(144, 160);
            this.machtenTextBox.TabIndex = 3;
            // 
            // toonButton
            // 
            this.toonButton.Location = new System.Drawing.Point(53, 12);
            this.toonButton.Name = "toonButton";
            this.toonButton.Size = new System.Drawing.Size(80, 23);
            this.toonButton.TabIndex = 2;
            this.toonButton.Text = "Derde macht";
            this.toonButton.Click += new System.EventHandler(this.toonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 244);
            this.Controls.Add(this.machtenTextBox);
            this.Controls.Add(this.toonButton);
            this.Name = "Form1";
            this.Text = "Oef 8.1 Toon getallen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox machtenTextBox;
        internal System.Windows.Forms.Button toonButton;
    }
}

