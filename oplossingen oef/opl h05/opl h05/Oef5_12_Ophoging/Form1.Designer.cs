namespace Oef5_12_Ophoging
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
            this.ophButton = new System.Windows.Forms.Button();
            this.getalTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ophButton
            // 
            this.ophButton.Location = new System.Drawing.Point(173, 10);
            this.ophButton.Name = "ophButton";
            this.ophButton.Size = new System.Drawing.Size(75, 23);
            this.ophButton.TabIndex = 5;
            this.ophButton.Text = "Ophoging";
            this.ophButton.UseVisualStyleBackColor = true;
            this.ophButton.Click += new System.EventHandler(this.ophButton_Click);
            // 
            // getalTextBox
            // 
            this.getalTextBox.Location = new System.Drawing.Point(67, 12);
            this.getalTextBox.Name = "getalTextBox";
            this.getalTextBox.Size = new System.Drawing.Size(100, 20);
            this.getalTextBox.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Getal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 58);
            this.Controls.Add(this.ophButton);
            this.Controls.Add(this.getalTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 5.12 Ophoging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ophButton;
        internal System.Windows.Forms.TextBox getalTextBox;
        internal System.Windows.Forms.Label Label1;
    }
}

