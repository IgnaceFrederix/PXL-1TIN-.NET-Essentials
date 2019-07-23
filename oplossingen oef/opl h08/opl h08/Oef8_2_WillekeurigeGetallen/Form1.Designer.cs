namespace Oef8_2_WillekeurigeGetallen
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
            this.toonButton = new System.Windows.Forms.Button();
            this.getallenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toonButton
            // 
            this.toonButton.Location = new System.Drawing.Point(98, 73);
            this.toonButton.Name = "toonButton";
            this.toonButton.Size = new System.Drawing.Size(75, 23);
            this.toonButton.TabIndex = 3;
            this.toonButton.Text = "Toon";
            this.toonButton.Click += new System.EventHandler(this.toonButton_Click);
            // 
            // getallenTextBox
            // 
            this.getallenTextBox.Location = new System.Drawing.Point(90, 113);
            this.getallenTextBox.Multiline = true;
            this.getallenTextBox.Name = "getallenTextBox";
            this.getallenTextBox.Size = new System.Drawing.Size(104, 176);
            this.getallenTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 363);
            this.Controls.Add(this.toonButton);
            this.Controls.Add(this.getallenTextBox);
            this.Name = "Form1";
            this.Text = "Oef 8.2. Willekeurige getallen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button toonButton;
        internal System.Windows.Forms.TextBox getallenTextBox;
    }
}

