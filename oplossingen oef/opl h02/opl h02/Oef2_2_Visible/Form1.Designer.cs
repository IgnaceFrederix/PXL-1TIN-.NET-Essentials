namespace Oef2_2_Visible
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
            this.coloredLabel = new System.Windows.Forms.Label();
            this.invisibleButton = new System.Windows.Forms.Button();
            this.visibleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coloredLabel
            // 
            this.coloredLabel.BackColor = System.Drawing.Color.Yellow;
            this.coloredLabel.Location = new System.Drawing.Point(41, 63);
            this.coloredLabel.Name = "coloredLabel";
            this.coloredLabel.Size = new System.Drawing.Size(200, 104);
            this.coloredLabel.TabIndex = 5;
            // 
            // invisibleButton
            // 
            this.invisibleButton.Location = new System.Drawing.Point(169, 23);
            this.invisibleButton.Name = "invisibleButton";
            this.invisibleButton.Size = new System.Drawing.Size(75, 23);
            this.invisibleButton.TabIndex = 4;
            this.invisibleButton.Text = "Invisible";
            this.invisibleButton.UseVisualStyleBackColor = true;
            this.invisibleButton.Click += new System.EventHandler(this.invisibleButton_Click);
            // 
            // visibleButton
            // 
            this.visibleButton.Location = new System.Drawing.Point(41, 23);
            this.visibleButton.Name = "visibleButton";
            this.visibleButton.Size = new System.Drawing.Size(75, 23);
            this.visibleButton.TabIndex = 3;
            this.visibleButton.Text = "Visible";
            this.visibleButton.UseVisualStyleBackColor = true;
            this.visibleButton.Click += new System.EventHandler(this.visibleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.coloredLabel);
            this.Controls.Add(this.invisibleButton);
            this.Controls.Add(this.visibleButton);
            this.Name = "Form1";
            this.Text = "Oef 2.2 Visible";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label coloredLabel;
        internal System.Windows.Forms.Button invisibleButton;
        internal System.Windows.Forms.Button visibleButton;
    }
}

