namespace Oef5_18_Ophoging
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
            this.ophogenButton = new System.Windows.Forms.Button();
            this.getalTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ophogenButton
            // 
            this.ophogenButton.Location = new System.Drawing.Point(71, 38);
            this.ophogenButton.Name = "ophogenButton";
            this.ophogenButton.Size = new System.Drawing.Size(100, 23);
            this.ophogenButton.TabIndex = 5;
            this.ophogenButton.Text = "Ophoging";
            this.ophogenButton.UseVisualStyleBackColor = true;
            this.ophogenButton.Click += new System.EventHandler(this.ophogenButton_Click);
            // 
            // getalTextBox
            // 
            this.getalTextBox.Location = new System.Drawing.Point(71, 12);
            this.getalTextBox.Name = "getalTextBox";
            this.getalTextBox.Size = new System.Drawing.Size(100, 20);
            this.getalTextBox.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Getal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 75);
            this.Controls.Add(this.ophogenButton);
            this.Controls.Add(this.getalTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 5.18 Ophoging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ophogenButton;
        internal System.Windows.Forms.TextBox getalTextBox;
        internal System.Windows.Forms.Label Label1;
    }
}

