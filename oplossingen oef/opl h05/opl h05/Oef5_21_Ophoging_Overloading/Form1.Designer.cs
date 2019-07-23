namespace Oef5_21_Ophoging_Overloading
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
            this.stringButton = new System.Windows.Forms.Button();
            this.doubleButton = new System.Windows.Forms.Button();
            this.intButton = new System.Windows.Forms.Button();
            this.waardeTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stringButton
            // 
            this.stringButton.Location = new System.Drawing.Point(100, 191);
            this.stringButton.Name = "stringButton";
            this.stringButton.Size = new System.Drawing.Size(100, 23);
            this.stringButton.TabIndex = 9;
            this.stringButton.Text = "Ophoging String";
            this.stringButton.UseVisualStyleBackColor = true;
            this.stringButton.Click += new System.EventHandler(this.stringButton_Click);
            // 
            // doubleButton
            // 
            this.doubleButton.Location = new System.Drawing.Point(100, 139);
            this.doubleButton.Name = "doubleButton";
            this.doubleButton.Size = new System.Drawing.Size(100, 23);
            this.doubleButton.TabIndex = 8;
            this.doubleButton.Text = "Ophoging Double";
            this.doubleButton.UseVisualStyleBackColor = true;
            this.doubleButton.Click += new System.EventHandler(this.doubleButton_Click);
            // 
            // intButton
            // 
            this.intButton.Location = new System.Drawing.Point(100, 89);
            this.intButton.Name = "intButton";
            this.intButton.Size = new System.Drawing.Size(100, 23);
            this.intButton.TabIndex = 7;
            this.intButton.Text = "Ophoging Integer";
            this.intButton.UseVisualStyleBackColor = true;
            this.intButton.Click += new System.EventHandler(this.intButton_Click);
            // 
            // waardeTextBox
            // 
            this.waardeTextBox.Location = new System.Drawing.Point(100, 36);
            this.waardeTextBox.Name = "waardeTextBox";
            this.waardeTextBox.Size = new System.Drawing.Size(100, 20);
            this.waardeTextBox.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(47, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Waarde:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.stringButton);
            this.Controls.Add(this.doubleButton);
            this.Controls.Add(this.intButton);
            this.Controls.Add(this.waardeTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 5.21 Ophoging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button stringButton;
        internal System.Windows.Forms.Button doubleButton;
        internal System.Windows.Forms.Button intButton;
        internal System.Windows.Forms.TextBox waardeTextBox;
        internal System.Windows.Forms.Label Label1;
    }
}

