namespace Oef5_14_SecNaarUMS
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
            this.secTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.umsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secTextBox
            // 
            this.secTextBox.Location = new System.Drawing.Point(83, 12);
            this.secTextBox.Name = "secTextBox";
            this.secTextBox.Size = new System.Drawing.Size(100, 20);
            this.secTextBox.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Seconden:";
            // 
            // umsButton
            // 
            this.umsButton.Location = new System.Drawing.Point(93, 50);
            this.umsButton.Name = "umsButton";
            this.umsButton.Size = new System.Drawing.Size(75, 23);
            this.umsButton.TabIndex = 3;
            this.umsButton.Text = "U:M:S";
            this.umsButton.Click += new System.EventHandler(this.umsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 84);
            this.Controls.Add(this.secTextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.umsButton);
            this.Name = "Form1";
            this.Text = "Oef 5.14 Sec naar UMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox secTextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button umsButton;
    }
}

