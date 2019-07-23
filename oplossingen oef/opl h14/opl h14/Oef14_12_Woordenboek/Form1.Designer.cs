namespace Oef14_12_Woordenboek
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.nl_enRadioButton = new System.Windows.Forms.RadioButton();
            this.en_nlRadioButton = new System.Windows.Forms.RadioButton();
            this.zoekButton = new System.Windows.Forms.Button();
            this.vertalingLabel = new System.Windows.Forms.Label();
            this.zoekStringTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.nl_enRadioButton);
            this.GroupBox1.Controls.Add(this.en_nlRadioButton);
            this.GroupBox1.Location = new System.Drawing.Point(101, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(176, 88);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Taal";
            // 
            // nl_enRadioButton
            // 
            this.nl_enRadioButton.Location = new System.Drawing.Point(24, 48);
            this.nl_enRadioButton.Name = "nl_enRadioButton";
            this.nl_enRadioButton.Size = new System.Drawing.Size(104, 24);
            this.nl_enRadioButton.TabIndex = 1;
            this.nl_enRadioButton.Text = "Ned/Engels";
            // 
            // en_nlRadioButton
            // 
            this.en_nlRadioButton.Checked = true;
            this.en_nlRadioButton.Location = new System.Drawing.Point(24, 16);
            this.en_nlRadioButton.Name = "en_nlRadioButton";
            this.en_nlRadioButton.Size = new System.Drawing.Size(104, 24);
            this.en_nlRadioButton.TabIndex = 0;
            this.en_nlRadioButton.TabStop = true;
            this.en_nlRadioButton.Text = "Engels/Ned";
            // 
            // zoekButton
            // 
            this.zoekButton.Location = new System.Drawing.Point(93, 172);
            this.zoekButton.Name = "zoekButton";
            this.zoekButton.Size = new System.Drawing.Size(75, 23);
            this.zoekButton.TabIndex = 6;
            this.zoekButton.Text = "Zoek";
            this.zoekButton.Click += new System.EventHandler(this.zoekButton_Click);
            // 
            // vertalingLabel
            // 
            this.vertalingLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.vertalingLabel.Location = new System.Drawing.Point(141, 116);
            this.vertalingLabel.Name = "vertalingLabel";
            this.vertalingLabel.Size = new System.Drawing.Size(100, 23);
            this.vertalingLabel.TabIndex = 5;
            // 
            // zoekStringTextBox
            // 
            this.zoekStringTextBox.Location = new System.Drawing.Point(13, 116);
            this.zoekStringTextBox.Name = "zoekStringTextBox";
            this.zoekStringTextBox.Size = new System.Drawing.Size(100, 20);
            this.zoekStringTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 208);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.zoekButton);
            this.Controls.Add(this.vertalingLabel);
            this.Controls.Add(this.zoekStringTextBox);
            this.Name = "Form1";
            this.Text = "Oef 14.12 Woordenboek";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton nl_enRadioButton;
        internal System.Windows.Forms.RadioButton en_nlRadioButton;
        internal System.Windows.Forms.Button zoekButton;
        internal System.Windows.Forms.Label vertalingLabel;
        internal System.Windows.Forms.TextBox zoekStringTextBox;
    }
}

