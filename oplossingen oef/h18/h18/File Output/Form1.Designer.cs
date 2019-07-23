namespace File_Output
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
            this.writeButton = new System.Windows.Forms.Button();
            this.myDocButton = new System.Windows.Forms.Button();
            this.writeAppButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(19, 12);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(136, 23);
            this.writeButton.TabIndex = 0;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // myDocButton
            // 
            this.myDocButton.Location = new System.Drawing.Point(19, 41);
            this.myDocButton.Name = "myDocButton";
            this.myDocButton.Size = new System.Drawing.Size(136, 23);
            this.myDocButton.TabIndex = 0;
            this.myDocButton.Text = "Write to My Documents";
            this.myDocButton.UseVisualStyleBackColor = true;
            this.myDocButton.Click += new System.EventHandler(this.myDocButton_Click);
            // 
            // writeAppButton
            // 
            this.writeAppButton.Location = new System.Drawing.Point(19, 70);
            this.writeAppButton.Name = "writeAppButton";
            this.writeAppButton.Size = new System.Drawing.Size(136, 23);
            this.writeAppButton.TabIndex = 0;
            this.writeAppButton.Text = "Write to AppData";
            this.writeAppButton.UseVisualStyleBackColor = true;
            this.writeAppButton.Click += new System.EventHandler(this.writeAppButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(16, 111);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 133);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.writeAppButton);
            this.Controls.Add(this.myDocButton);
            this.Controls.Add(this.writeButton);
            this.Name = "Form1";
            this.Text = "File Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button myDocButton;
        private System.Windows.Forms.Button writeAppButton;
        private System.Windows.Forms.Label statusLabel;
    }
}

