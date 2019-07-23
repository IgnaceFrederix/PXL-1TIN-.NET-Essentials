namespace Interest_Calculation
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.yearButton = new System.Windows.Forms.Button();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.initialAmountTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(21, 138);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(232, 112);
            this.resultTextBox.TabIndex = 11;
            // 
            // yearButton
            // 
            this.yearButton.Location = new System.Drawing.Point(82, 95);
            this.yearButton.Name = "yearButton";
            this.yearButton.Size = new System.Drawing.Size(96, 24);
            this.yearButton.TabIndex = 10;
            this.yearButton.Text = "Another year";
            this.yearButton.Click += new System.EventHandler(this.yearButton_Click);
            // 
            // rateTextBox
            // 
            this.rateTextBox.Location = new System.Drawing.Point(170, 55);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.Size = new System.Drawing.Size(83, 20);
            this.rateTextBox.TabIndex = 9;
            this.rateTextBox.Text = "10";
            // 
            // initialAmountTextBox
            // 
            this.initialAmountTextBox.Location = new System.Drawing.Point(170, 15);
            this.initialAmountTextBox.Name = "initialAmountTextBox";
            this.initialAmountTextBox.Size = new System.Drawing.Size(83, 20);
            this.initialAmountTextBox.TabIndex = 8;
            this.initialAmountTextBox.Text = "100";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(18, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 32);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Enter interest rate";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(18, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 24);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Enter initial amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.yearButton);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(this.initialAmountTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Interest Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox resultTextBox;
        internal System.Windows.Forms.Button yearButton;
        internal System.Windows.Forms.TextBox rateTextBox;
        internal System.Windows.Forms.TextBox initialAmountTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

