namespace Testvraag8_4_kwadraten
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
            this.kwadraatButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kwadraatButton
            // 
            this.kwadraatButton.Location = new System.Drawing.Point(101, 12);
            this.kwadraatButton.Name = "kwadraatButton";
            this.kwadraatButton.Size = new System.Drawing.Size(75, 23);
            this.kwadraatButton.TabIndex = 0;
            this.kwadraatButton.Text = "Toon";
            this.kwadraatButton.UseVisualStyleBackColor = true;
            this.kwadraatButton.Click += new System.EventHandler(this.kwadraatButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 50);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(260, 200);
            this.resultTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.kwadraatButton);
            this.Name = "Form1";
            this.Text = "Kwadraten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kwadraatButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

