namespace Oef16_8_EmailAdres
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
            this.addButton = new System.Windows.Forms.Button();
            this.reservedTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.reservedListBox = new System.Windows.Forms.ListBox();
            this.testButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(160, 145);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(120, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Voeg woord toe";
            this.addButton.Click += new System.EventHandler(this.reservedButton_Click);
            // 
            // reservedTextBox
            // 
            this.reservedTextBox.Location = new System.Drawing.Point(160, 107);
            this.reservedTextBox.Name = "reservedTextBox";
            this.reservedTextBox.Size = new System.Drawing.Size(120, 20);
            this.reservedTextBox.TabIndex = 12;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(12, 110);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(136, 23);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Geef gereserveerd woord:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Geef e-mailadres:";
            // 
            // reservedListBox
            // 
            this.reservedListBox.Items.AddRange(new object[] {
            "webmaster",
            "regering"});
            this.reservedListBox.Location = new System.Drawing.Point(160, 192);
            this.reservedListBox.Name = "reservedListBox";
            this.reservedListBox.Size = new System.Drawing.Size(120, 95);
            this.reservedListBox.TabIndex = 9;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(205, 35);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 8;
            this.testButton.Text = "Test";
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(108, 9);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(172, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 310);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.reservedTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.reservedListBox);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.emailTextBox);
            this.Name = "Form1";
            this.Text = "Oef 16.8 Emailadres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button addButton;
        internal System.Windows.Forms.TextBox reservedTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox reservedListBox;
        internal System.Windows.Forms.Button testButton;
        internal System.Windows.Forms.TextBox emailTextBox;
    }
}

