namespace Oef14_15_Sorteren
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
            this.sorteerButton = new System.Windows.Forms.Button();
            this.getallenLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.getalTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sorteerButton
            // 
            this.sorteerButton.Location = new System.Drawing.Point(94, 139);
            this.sorteerButton.Name = "sorteerButton";
            this.sorteerButton.Size = new System.Drawing.Size(75, 23);
            this.sorteerButton.TabIndex = 9;
            this.sorteerButton.Text = "Sorteer";
            this.sorteerButton.UseVisualStyleBackColor = true;
            this.sorteerButton.Click += new System.EventHandler(this.sorteerButton_Click);
            // 
            // getallenLabel
            // 
            this.getallenLabel.AutoSize = true;
            this.getallenLabel.Location = new System.Drawing.Point(15, 76);
            this.getallenLabel.Name = "getallenLabel";
            this.getallenLabel.Size = new System.Drawing.Size(35, 13);
            this.getallenLabel.TabIndex = 8;
            this.getallenLabel.Text = "label2";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(159, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // getalTextBox
            // 
            this.getalTextBox.Location = new System.Drawing.Point(53, 22);
            this.getalTextBox.Name = "getalTextBox";
            this.getalTextBox.Size = new System.Drawing.Size(100, 20);
            this.getalTextBox.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Getal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 180);
            this.Controls.Add(this.sorteerButton);
            this.Controls.Add(this.getallenLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.getalTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 14.15 Sorteren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button sorteerButton;
        internal System.Windows.Forms.Label getallenLabel;
        internal System.Windows.Forms.Button addButton;
        internal System.Windows.Forms.TextBox getalTextBox;
        internal System.Windows.Forms.Label Label1;
    }
}

