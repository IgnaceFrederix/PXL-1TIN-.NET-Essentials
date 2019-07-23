namespace Oef2_3_Image
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.visibleButton = new System.Windows.Forms.Button();
            this.invisibleButton = new System.Windows.Forms.Button();
            this.imageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // visibleButton
            // 
            this.visibleButton.Location = new System.Drawing.Point(27, 47);
            this.visibleButton.Name = "visibleButton";
            this.visibleButton.Size = new System.Drawing.Size(75, 23);
            this.visibleButton.TabIndex = 0;
            this.visibleButton.Text = "Visible";
            this.visibleButton.UseVisualStyleBackColor = true;
            this.visibleButton.Click += new System.EventHandler(this.visibleButton_Click);
            // 
            // invisibleButton
            // 
            this.invisibleButton.Location = new System.Drawing.Point(449, 47);
            this.invisibleButton.Name = "invisibleButton";
            this.invisibleButton.Size = new System.Drawing.Size(75, 23);
            this.invisibleButton.TabIndex = 1;
            this.invisibleButton.Text = "Invisible";
            this.invisibleButton.UseVisualStyleBackColor = true;
            this.invisibleButton.Click += new System.EventHandler(this.invisibleButton_Click);
            // 
            // imageLabel
            // 
            this.imageLabel.Image = ((System.Drawing.Image)(resources.GetObject("imageLabel.Image")));
            this.imageLabel.Location = new System.Drawing.Point(24, 99);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(500, 500);
            this.imageLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 630);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.invisibleButton);
            this.Controls.Add(this.visibleButton);
            this.Name = "Form1";
            this.Text = "Oef 2.3 Image";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button visibleButton;
        private System.Windows.Forms.Button invisibleButton;
        private System.Windows.Forms.Label imageLabel;

    }
}

