﻿namespace Selecting_an_item
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shoppingListBox
            // 
            this.shoppingListBox.FormattingEnabled = true;
            this.shoppingListBox.Items.AddRange(new object[] {
            "bread",
            "milk",
            "coffee",
            "tea"});
            this.shoppingListBox.Location = new System.Drawing.Point(12, 19);
            this.shoppingListBox.Name = "shoppingListBox";
            this.shoppingListBox.Size = new System.Drawing.Size(120, 95);
            this.shoppingListBox.TabIndex = 0;
            this.shoppingListBox.SelectedIndexChanged += new System.EventHandler(this.shoppingListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(138, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "you have selected item number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(225, 56);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(26, 20);
            this.numberTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 130);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shoppingListBox);
            this.Name = "Form1";
            this.Text = "Selecting an item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox shoppingListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
    }
}

