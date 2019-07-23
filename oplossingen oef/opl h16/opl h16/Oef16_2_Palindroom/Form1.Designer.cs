namespace Oef16_2_Palindroom
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
            this.controleerButton = new System.Windows.Forms.Button();
            this.woordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(15, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 23);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Geef woord:";
            // 
            // controleerButton
            // 
            this.controleerButton.Location = new System.Drawing.Point(95, 65);
            this.controleerButton.Name = "controleerButton";
            this.controleerButton.Size = new System.Drawing.Size(100, 23);
            this.controleerButton.TabIndex = 4;
            this.controleerButton.Text = "Controleer";
            this.controleerButton.Click += new System.EventHandler(this.controleerButton_Click);
            // 
            // woordTextBox
            // 
            this.woordTextBox.Location = new System.Drawing.Point(95, 21);
            this.woordTextBox.Name = "woordTextBox";
            this.woordTextBox.Size = new System.Drawing.Size(100, 20);
            this.woordTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 112);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.controleerButton);
            this.Controls.Add(this.woordTextBox);
            this.Name = "Form1";
            this.Text = "Oef 16.2 Palindroom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button controleerButton;
        internal System.Windows.Forms.TextBox woordTextBox;
    }
}

