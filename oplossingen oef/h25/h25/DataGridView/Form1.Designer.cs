namespace DataGridView
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
            this.salesAboveTextBox = new System.Windows.Forms.TextBox();
            this.highSalesButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sqlLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.artistsDataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales above:";
            // 
            // salesAboveTextBox
            // 
            this.salesAboveTextBox.Location = new System.Drawing.Point(87, 23);
            this.salesAboveTextBox.Name = "salesAboveTextBox";
            this.salesAboveTextBox.Size = new System.Drawing.Size(53, 20);
            this.salesAboveTextBox.TabIndex = 1;
            // 
            // highSalesButton
            // 
            this.highSalesButton.Location = new System.Drawing.Point(297, 20);
            this.highSalesButton.Name = "highSalesButton";
            this.highSalesButton.Size = new System.Drawing.Size(111, 23);
            this.highSalesButton.TabIndex = 2;
            this.highSalesButton.Text = "Show High Sales";
            this.highSalesButton.UseVisualStyleBackColor = true;
            this.highSalesButton.Click += new System.EventHandler(this.highSalesButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.sqlLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 347);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(420, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "SQL Code: ";
            // 
            // sqlLabel
            // 
            this.sqlLabel.Name = "sqlLabel";
            this.sqlLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // artistsDataGridView
            // 
            this.artistsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artistsDataGridView.Location = new System.Drawing.Point(15, 50);
            this.artistsDataGridView.Name = "artistsDataGridView";
            this.artistsDataGridView.Size = new System.Drawing.Size(393, 276);
            this.artistsDataGridView.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 369);
            this.Controls.Add(this.artistsDataGridView);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.highSalesButton);
            this.Controls.Add(this.salesAboveTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Data Grid View";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artistsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salesAboveTextBox;
        private System.Windows.Forms.Button highSalesButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sqlLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView artistsDataGridView;
    }
}

