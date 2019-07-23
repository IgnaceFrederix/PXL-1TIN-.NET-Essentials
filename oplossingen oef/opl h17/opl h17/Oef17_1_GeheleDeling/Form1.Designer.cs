namespace Oef17_1_GeheleDeling
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
            this.berekenButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.getalBTextBox = new System.Windows.Forms.TextBox();
            this.getalATextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(24, 156);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 7;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.UseVisualStyleBackColor = true;
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(21, 107);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(39, 13);
            this.resultLabel.TabIndex = 8;
            this.resultLabel.Text = "Label3";
            // 
            // getalBTextBox
            // 
            this.getalBTextBox.Location = new System.Drawing.Point(90, 50);
            this.getalBTextBox.Name = "getalBTextBox";
            this.getalBTextBox.Size = new System.Drawing.Size(100, 20);
            this.getalBTextBox.TabIndex = 6;
            // 
            // getalATextBox
            // 
            this.getalATextBox.Location = new System.Drawing.Point(90, 15);
            this.getalATextBox.Name = "getalATextBox";
            this.getalATextBox.Size = new System.Drawing.Size(100, 20);
            this.getalATextBox.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(21, 53);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Getal b:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(21, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(44, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Getal a:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 193);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.getalBTextBox);
            this.Controls.Add(this.getalATextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 17.1 Gehele deling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.Label resultLabel;
        internal System.Windows.Forms.TextBox getalBTextBox;
        internal System.Windows.Forms.TextBox getalATextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

