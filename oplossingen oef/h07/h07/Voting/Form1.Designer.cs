namespace Voting
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
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.decisionLabel = new System.Windows.Forms.Label();
            this.commentaryLabel = new System.Windows.Forms.Label();
            this.signOffLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(15, 59);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 1;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(16, 106);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 2;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // decisionLabel
            // 
            this.decisionLabel.AutoSize = true;
            this.decisionLabel.Location = new System.Drawing.Point(13, 151);
            this.decisionLabel.Name = "decisionLabel";
            this.decisionLabel.Size = new System.Drawing.Size(35, 13);
            this.decisionLabel.TabIndex = 3;
            this.decisionLabel.Text = "label2";
            // 
            // commentaryLabel
            // 
            this.commentaryLabel.AutoSize = true;
            this.commentaryLabel.Location = new System.Drawing.Point(13, 178);
            this.commentaryLabel.Name = "commentaryLabel";
            this.commentaryLabel.Size = new System.Drawing.Size(35, 13);
            this.commentaryLabel.TabIndex = 3;
            this.commentaryLabel.Text = "label2";
            // 
            // signOffLabel
            // 
            this.signOffLabel.AutoSize = true;
            this.signOffLabel.Location = new System.Drawing.Point(12, 209);
            this.signOffLabel.Name = "signOffLabel";
            this.signOffLabel.Size = new System.Drawing.Size(35, 13);
            this.signOffLabel.TabIndex = 3;
            this.signOffLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 262);
            this.Controls.Add(this.signOffLabel);
            this.Controls.Add(this.commentaryLabel);
            this.Controls.Add(this.decisionLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Voting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label decisionLabel;
        private System.Windows.Forms.Label commentaryLabel;
        private System.Windows.Forms.Label signOffLabel;
    }
}

