namespace Oef8_11_Kinderliedje
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
            this.rijmTextBox = new System.Windows.Forms.TextBox();
            this.zingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rijmTextBox
            // 
            this.rijmTextBox.Location = new System.Drawing.Point(37, 93);
            this.rijmTextBox.Multiline = true;
            this.rijmTextBox.Name = "rijmTextBox";
            this.rijmTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rijmTextBox.Size = new System.Drawing.Size(520, 256);
            this.rijmTextBox.TabIndex = 3;
            // 
            // zingButton
            // 
            this.zingButton.Location = new System.Drawing.Point(221, 37);
            this.zingButton.Name = "zingButton";
            this.zingButton.Size = new System.Drawing.Size(104, 23);
            this.zingButton.TabIndex = 2;
            this.zingButton.Text = "Zing kinderliedje";
            this.zingButton.Click += new System.EventHandler(this.zingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 387);
            this.Controls.Add(this.rijmTextBox);
            this.Controls.Add(this.zingButton);
            this.Name = "Form1";
            this.Text = "Oef 8.11 Kinderliedje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox rijmTextBox;
        internal System.Windows.Forms.Button zingButton;
    }
}

