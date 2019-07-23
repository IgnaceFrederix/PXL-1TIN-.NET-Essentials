namespace Oef16_7_PlusMinGeheugen
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.invoerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(12, 121);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(260, 31);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "0000";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(103, 50);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 4;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.UseVisualStyleBackColor = true;
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // invoerTextBox
            // 
            this.invoerTextBox.Location = new System.Drawing.Point(12, 12);
            this.invoerTextBox.Name = "invoerTextBox";
            this.invoerTextBox.Size = new System.Drawing.Size(260, 20);
            this.invoerTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 170);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.invoerTextBox);
            this.Name = "Form1";
            this.Text = "Oef 16.7 Plus min geheugen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label resultLabel;
        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.TextBox invoerTextBox;
    }
}

