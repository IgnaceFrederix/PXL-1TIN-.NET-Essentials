namespace Oef16_3_TypeGetal
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
            this.Label1 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.getalTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(28, 23);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Geef een getal in:";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(148, 78);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(100, 23);
            this.testButton.TabIndex = 4;
            this.testButton.Text = "Test";
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // getalTextBox
            // 
            this.getalTextBox.Location = new System.Drawing.Point(148, 23);
            this.getalTextBox.Name = "getalTextBox";
            this.getalTextBox.Size = new System.Drawing.Size(100, 20);
            this.getalTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 123);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.getalTextBox);
            this.Name = "Form1";
            this.Text = "Oef 16.3 Type getal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button testButton;
        internal System.Windows.Forms.TextBox getalTextBox;
    }
}

