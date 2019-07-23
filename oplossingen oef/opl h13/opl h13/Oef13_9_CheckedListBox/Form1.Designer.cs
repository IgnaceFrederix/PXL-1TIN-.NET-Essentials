namespace Oef13_9_CheckedListBox
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
            this.sourceCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.targetListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sourceCheckedListBox
            // 
            this.sourceCheckedListBox.CheckOnClick = true;
            this.sourceCheckedListBox.FormattingEnabled = true;
            this.sourceCheckedListBox.Items.AddRange(new object[] {
            "bread",
            "milk",
            "coffee",
            "tea"});
            this.sourceCheckedListBox.Location = new System.Drawing.Point(12, 26);
            this.sourceCheckedListBox.Name = "sourceCheckedListBox";
            this.sourceCheckedListBox.Size = new System.Drawing.Size(87, 94);
            this.sourceCheckedListBox.TabIndex = 0;
            this.sourceCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.sourceCheckedListBox_SelectedIndexChanged);
            // 
            // targetListBox
            // 
            this.targetListBox.FormattingEnabled = true;
            this.targetListBox.Location = new System.Drawing.Point(153, 26);
            this.targetListBox.Name = "targetListBox";
            this.targetListBox.Size = new System.Drawing.Size(105, 95);
            this.targetListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.targetListBox);
            this.Controls.Add(this.sourceCheckedListBox);
            this.Name = "Form1";
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox sourceCheckedListBox;
        private System.Windows.Forms.ListBox targetListBox;
    }
}

