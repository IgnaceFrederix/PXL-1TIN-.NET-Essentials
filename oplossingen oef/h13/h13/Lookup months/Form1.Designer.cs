namespace Lookup_months
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
            this.label1 = new System.Windows.Forms.Label();
            this.monthNumberTextBox = new System.Windows.Forms.TextBox();
            this.lookupButton = new System.Windows.Forms.Button();
            this.monthNameTextBox = new System.Windows.Forms.TextBox();
            this.monthListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Month";
            // 
            // monthNumberTextBox
            // 
            this.monthNumberTextBox.Location = new System.Drawing.Point(55, 30);
            this.monthNumberTextBox.Name = "monthNumberTextBox";
            this.monthNumberTextBox.Size = new System.Drawing.Size(34, 20);
            this.monthNumberTextBox.TabIndex = 1;
            // 
            // lookupButton
            // 
            this.lookupButton.Location = new System.Drawing.Point(99, 27);
            this.lookupButton.Name = "lookupButton";
            this.lookupButton.Size = new System.Drawing.Size(56, 23);
            this.lookupButton.TabIndex = 2;
            this.lookupButton.Text = "is";
            this.lookupButton.UseVisualStyleBackColor = true;
            this.lookupButton.Click += new System.EventHandler(this.lookupButton_Click);
            // 
            // monthNameTextBox
            // 
            this.monthNameTextBox.Location = new System.Drawing.Point(168, 30);
            this.monthNameTextBox.Name = "monthNameTextBox";
            this.monthNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthNameTextBox.TabIndex = 3;
            // 
            // monthListBox
            // 
            this.monthListBox.FormattingEnabled = true;
            this.monthListBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthListBox.Location = new System.Drawing.Point(15, 113);
            this.monthListBox.Name = "monthListBox";
            this.monthListBox.Size = new System.Drawing.Size(120, 95);
            this.monthListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 76);
            this.Controls.Add(this.monthListBox);
            this.Controls.Add(this.monthNameTextBox);
            this.Controls.Add(this.lookupButton);
            this.Controls.Add(this.monthNumberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lookup months";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox monthNumberTextBox;
        private System.Windows.Forms.Button lookupButton;
        private System.Windows.Forms.TextBox monthNameTextBox;
        private System.Windows.Forms.ListBox monthListBox;
    }
}

