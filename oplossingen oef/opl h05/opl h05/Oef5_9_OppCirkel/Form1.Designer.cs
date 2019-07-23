namespace Oef5_9_OppCirkel
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
            this.straalTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // straalTextBox
            // 
            this.straalTextBox.Location = new System.Drawing.Point(66, 26);
            this.straalTextBox.Name = "straalTextBox";
            this.straalTextBox.Size = new System.Drawing.Size(100, 20);
            this.straalTextBox.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Straal:";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(91, 73);
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
            this.Controls.Add(this.straalTextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.berekenButton);
            this.Name = "Form1";
            this.Text = "Oef 5.9 Oppervlakte cirkel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox straalTextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button berekenButton;
    }
}

