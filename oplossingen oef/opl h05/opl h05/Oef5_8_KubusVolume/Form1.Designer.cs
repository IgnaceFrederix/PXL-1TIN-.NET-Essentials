namespace Oef5_8_KubusVolume
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
            this.ribbeTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ribbeTextBox
            // 
            this.ribbeTextBox.Location = new System.Drawing.Point(83, 31);
            this.ribbeTextBox.Name = "ribbeTextBox";
            this.ribbeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ribbeTextBox.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Ribbe:";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(108, 70);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 3;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 114);
            this.Controls.Add(this.ribbeTextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.berekenButton);
            this.Name = "Form1";
            this.Text = "Oef 5.8 Kubus volume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox ribbeTextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button berekenButton;
    }
}

