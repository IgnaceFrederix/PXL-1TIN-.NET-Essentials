namespace Arithmetic
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
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.largestButton = new System.Windows.Forms.Button();
            this.largestTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.Items.AddRange(new object[] {
            "6",
            "45",
            "32",
            "9",
            "876",
            "2",
            "193",
            "49",
            "66",
            "356",
            "13",
            "94"});
            this.numberListBox.Location = new System.Drawing.Point(95, 12);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(77, 186);
            this.numberListBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 38);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(12, 12);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(75, 20);
            this.numberTextBox.TabIndex = 2;
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(178, 175);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 23);
            this.sumButton.TabIndex = 3;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(178, 149);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(75, 20);
            this.sumTextBox.TabIndex = 4;
            // 
            // largestButton
            // 
            this.largestButton.Location = new System.Drawing.Point(178, 38);
            this.largestButton.Name = "largestButton";
            this.largestButton.Size = new System.Drawing.Size(75, 23);
            this.largestButton.TabIndex = 3;
            this.largestButton.Text = "Largest";
            this.largestButton.UseVisualStyleBackColor = true;
            this.largestButton.Click += new System.EventHandler(this.largestButton_Click);
            // 
            // largestTextBox
            // 
            this.largestTextBox.Location = new System.Drawing.Point(178, 12);
            this.largestTextBox.Name = "largestTextBox";
            this.largestTextBox.Size = new System.Drawing.Size(75, 20);
            this.largestTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 210);
            this.Controls.Add(this.largestTextBox);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.largestButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numberListBox);
            this.Name = "Form1";
            this.Text = "Arithmetic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Button largestButton;
        private System.Windows.Forms.TextBox largestTextBox;
    }
}

