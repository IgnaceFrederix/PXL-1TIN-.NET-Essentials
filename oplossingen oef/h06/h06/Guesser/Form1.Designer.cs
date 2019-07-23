namespace Guesser
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
            this.guessLabel = new System.Windows.Forms.Label();
            this.correctButton = new System.Windows.Forms.Button();
            this.wrongButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer guesses that your age is:";
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(132, 75);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(35, 13);
            this.guessLabel.TabIndex = 1;
            this.guessLabel.Text = "label2";
            // 
            // correctButton
            // 
            this.correctButton.Location = new System.Drawing.Point(33, 134);
            this.correctButton.Name = "correctButton";
            this.correctButton.Size = new System.Drawing.Size(75, 23);
            this.correctButton.TabIndex = 2;
            this.correctButton.Text = "Correct";
            this.correctButton.UseVisualStyleBackColor = true;
            this.correctButton.Click += new System.EventHandler(this.correctButton_Click);
            // 
            // wrongButton
            // 
            this.wrongButton.Location = new System.Drawing.Point(173, 134);
            this.wrongButton.Name = "wrongButton";
            this.wrongButton.Size = new System.Drawing.Size(75, 23);
            this.wrongButton.TabIndex = 2;
            this.wrongButton.Text = "Wrong";
            this.wrongButton.UseVisualStyleBackColor = true;
            this.wrongButton.Click += new System.EventHandler(this.wrongButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.wrongButton);
            this.Controls.Add(this.correctButton);
            this.Controls.Add(this.guessLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Guesser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.Button correctButton;
        private System.Windows.Forms.Button wrongButton;
    }
}

