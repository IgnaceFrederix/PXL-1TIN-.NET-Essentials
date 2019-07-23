namespace FormatDemo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.intTextBox = new System.Windows.Forms.TextBox();
            this.doubleTextBox = new System.Windows.Forms.TextBox();
            this.formatTextBox = new System.Windows.Forms.TextBox();
            this.intButton = new System.Windows.Forms.Button();
            this.doubleButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "int getal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "double getal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "format string:";
            // 
            // intTextBox
            // 
            this.intTextBox.Location = new System.Drawing.Point(113, 33);
            this.intTextBox.Name = "intTextBox";
            this.intTextBox.Size = new System.Drawing.Size(117, 20);
            this.intTextBox.TabIndex = 1;
            // 
            // doubleTextBox
            // 
            this.doubleTextBox.Location = new System.Drawing.Point(113, 77);
            this.doubleTextBox.Name = "doubleTextBox";
            this.doubleTextBox.Size = new System.Drawing.Size(117, 20);
            this.doubleTextBox.TabIndex = 1;
            // 
            // formatTextBox
            // 
            this.formatTextBox.Location = new System.Drawing.Point(113, 122);
            this.formatTextBox.Name = "formatTextBox";
            this.formatTextBox.Size = new System.Drawing.Size(117, 20);
            this.formatTextBox.TabIndex = 1;
            // 
            // intButton
            // 
            this.intButton.Location = new System.Drawing.Point(236, 31);
            this.intButton.Name = "intButton";
            this.intButton.Size = new System.Drawing.Size(75, 23);
            this.intButton.TabIndex = 2;
            this.intButton.Text = "Format";
            this.intButton.UseVisualStyleBackColor = true;
            this.intButton.Click += new System.EventHandler(this.intButton_Click);
            // 
            // doubleButton
            // 
            this.doubleButton.Location = new System.Drawing.Point(236, 75);
            this.doubleButton.Name = "doubleButton";
            this.doubleButton.Size = new System.Drawing.Size(75, 23);
            this.doubleButton.TabIndex = 2;
            this.doubleButton.Text = "Format";
            this.doubleButton.UseVisualStyleBackColor = true;
            this.doubleButton.Click += new System.EventHandler(this.doubleButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(110, 187);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 24);
            this.resultLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 262);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.doubleButton);
            this.Controls.Add(this.intButton);
            this.Controls.Add(this.formatTextBox);
            this.Controls.Add(this.doubleTextBox);
            this.Controls.Add(this.intTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formatteringen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox intTextBox;
        private System.Windows.Forms.TextBox doubleTextBox;
        private System.Windows.Forms.TextBox formatTextBox;
        private System.Windows.Forms.Button intButton;
        private System.Windows.Forms.Button doubleButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

