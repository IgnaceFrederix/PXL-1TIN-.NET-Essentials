namespace Oef5_11_OppCilinder
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
            this.hoogteTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.straalTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoogteTextBox
            // 
            this.hoogteTextBox.Location = new System.Drawing.Point(77, 59);
            this.hoogteTextBox.Name = "hoogteTextBox";
            this.hoogteTextBox.Size = new System.Drawing.Size(100, 20);
            this.hoogteTextBox.TabIndex = 9;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 62);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(42, 13);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Hoogte";
            // 
            // straalTextBox
            // 
            this.straalTextBox.Location = new System.Drawing.Point(77, 12);
            this.straalTextBox.Name = "straalTextBox";
            this.straalTextBox.Size = new System.Drawing.Size(100, 20);
            this.straalTextBox.TabIndex = 7;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(34, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Straal";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(77, 110);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(100, 23);
            this.berekenButton.TabIndex = 5;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 145);
            this.Controls.Add(this.hoogteTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.straalTextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.berekenButton);
            this.Name = "Form1";
            this.Text = "Oef 5.11 Opp Cilinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox hoogteTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox straalTextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button berekenButton;
    }
}

