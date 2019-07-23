namespace Oef8_9_SomReeks
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
            this.berekenButton = new System.Windows.Forms.Button();
            this.termenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(204, 260);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(136, 23);
            this.berekenButton.TabIndex = 3;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // termenTextBox
            // 
            this.termenTextBox.Location = new System.Drawing.Point(36, 12);
            this.termenTextBox.Multiline = true;
            this.termenTextBox.Name = "termenTextBox";
            this.termenTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.termenTextBox.Size = new System.Drawing.Size(456, 232);
            this.termenTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 295);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.termenTextBox);
            this.Name = "Form1";
            this.Text = "Oef 8.9 Som van een reeks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.TextBox termenTextBox;
    }
}

