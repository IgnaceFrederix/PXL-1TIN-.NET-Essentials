namespace Gambling
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
            this.throwButton = new System.Windows.Forms.Button();
            this.valuesLabel = new System.Windows.Forms.Label();
            this.outcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // throwButton
            // 
            this.throwButton.Location = new System.Drawing.Point(97, 30);
            this.throwButton.Name = "throwButton";
            this.throwButton.Size = new System.Drawing.Size(75, 23);
            this.throwButton.TabIndex = 0;
            this.throwButton.Text = "Throw";
            this.throwButton.UseVisualStyleBackColor = true;
            this.throwButton.Click += new System.EventHandler(this.throwButton_Click);
            // 
            // valuesLabel
            // 
            this.valuesLabel.AutoSize = true;
            this.valuesLabel.Location = new System.Drawing.Point(41, 93);
            this.valuesLabel.Name = "valuesLabel";
            this.valuesLabel.Size = new System.Drawing.Size(0, 13);
            this.valuesLabel.TabIndex = 1;
            // 
            // outcomeLabel
            // 
            this.outcomeLabel.AutoSize = true;
            this.outcomeLabel.Location = new System.Drawing.Point(41, 147);
            this.outcomeLabel.Name = "outcomeLabel";
            this.outcomeLabel.Size = new System.Drawing.Size(0, 13);
            this.outcomeLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.outcomeLabel);
            this.Controls.Add(this.valuesLabel);
            this.Controls.Add(this.throwButton);
            this.Name = "Form1";
            this.Text = "Gambling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button throwButton;
        private System.Windows.Forms.Label valuesLabel;
        private System.Windows.Forms.Label outcomeLabel;
    }
}

