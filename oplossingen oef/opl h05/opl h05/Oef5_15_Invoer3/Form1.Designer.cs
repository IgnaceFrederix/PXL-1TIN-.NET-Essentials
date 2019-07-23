namespace Oef5_15_Invoer3
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
            this.ingevenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ingevenButton
            // 
            this.ingevenButton.Location = new System.Drawing.Point(91, 118);
            this.ingevenButton.Name = "ingevenButton";
            this.ingevenButton.Size = new System.Drawing.Size(106, 23);
            this.ingevenButton.TabIndex = 3;
            this.ingevenButton.Text = "Getallen ingeven";
            this.ingevenButton.UseVisualStyleBackColor = true;
            this.ingevenButton.Click += new System.EventHandler(this.ingevenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "a:";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(49, 30);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(42, 20);
            this.aTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b:";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(140, 30);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(42, 20);
            this.bTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "c:";
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(244, 30);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(42, 20);
            this.cTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 195);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ingevenButton);
            this.Name = "Form1";
            this.Text = "Oef 5.15 Invoer3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ingevenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cTextBox;
    }
}

