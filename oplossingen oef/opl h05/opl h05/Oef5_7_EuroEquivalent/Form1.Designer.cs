namespace Oef5_7_EuroEquivalent
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
            this.eurosTextBox = new System.Windows.Forms.TextBox();
            this.dollarsTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // eurosTextBox
            // 
            this.eurosTextBox.Location = new System.Drawing.Point(79, 152);
            this.eurosTextBox.Name = "eurosTextBox";
            this.eurosTextBox.ReadOnly = true;
            this.eurosTextBox.Size = new System.Drawing.Size(100, 20);
            this.eurosTextBox.TabIndex = 6;
            // 
            // dollarsTextBox
            // 
            this.dollarsTextBox.Location = new System.Drawing.Point(79, 29);
            this.dollarsTextBox.Name = "dollarsTextBox";
            this.dollarsTextBox.Size = new System.Drawing.Size(100, 20);
            this.dollarsTextBox.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(25, 155);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 23);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Euro\'s:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(25, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 23);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Dollars:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(79, 82);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(96, 23);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "Bereken euro\'s";
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 185);
            this.Controls.Add(this.eurosTextBox);
            this.Controls.Add(this.dollarsTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.convertButton);
            this.Name = "Form1";
            this.Text = "Oef 5.7 EuroEquivalent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox eurosTextBox;
        internal System.Windows.Forms.TextBox dollarsTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button convertButton;
    }
}

