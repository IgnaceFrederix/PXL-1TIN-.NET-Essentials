namespace Oef14_18_Kaartspel
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
            this.stokTextBox = new System.Windows.Forms.TextBox();
            this.stokButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stokTextBox
            // 
            this.stokTextBox.Location = new System.Drawing.Point(20, 50);
            this.stokTextBox.Multiline = true;
            this.stokTextBox.Name = "stokTextBox";
            this.stokTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stokTextBox.Size = new System.Drawing.Size(260, 200);
            this.stokTextBox.TabIndex = 3;
            // 
            // stokButton
            // 
            this.stokButton.Location = new System.Drawing.Point(94, 12);
            this.stokButton.Name = "stokButton";
            this.stokButton.Size = new System.Drawing.Size(75, 23);
            this.stokButton.TabIndex = 2;
            this.stokButton.Text = "Maak stok";
            this.stokButton.UseVisualStyleBackColor = true;
            this.stokButton.Click += new System.EventHandler(this.stokButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 263);
            this.Controls.Add(this.stokTextBox);
            this.Controls.Add(this.stokButton);
            this.Name = "Form1";
            this.Text = "Oef 14.18 Kaartspel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox stokTextBox;
        internal System.Windows.Forms.Button stokButton;
    }
}

