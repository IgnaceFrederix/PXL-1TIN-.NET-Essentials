namespace CountListBox
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
            this.shoppingListBox = new System.Windows.Forms.ListBox();
            this.countButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shoppingListBox
            // 
            this.shoppingListBox.FormattingEnabled = true;
            this.shoppingListBox.Items.AddRange(new object[] {
            "coffee",
            "tea",
            "sugar"});
            this.shoppingListBox.Location = new System.Drawing.Point(12, 12);
            this.shoppingListBox.Name = "shoppingListBox";
            this.shoppingListBox.Size = new System.Drawing.Size(120, 95);
            this.shoppingListBox.TabIndex = 0;
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(166, 39);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 1;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.shoppingListBox);
            this.Name = "Form1";
            this.Text = "Count";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox shoppingListBox;
        private System.Windows.Forms.Button countButton;
    }
}

