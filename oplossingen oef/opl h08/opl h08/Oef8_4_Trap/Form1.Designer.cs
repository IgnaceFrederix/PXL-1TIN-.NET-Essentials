namespace Oef8_4_Trap
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
            this.trapPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trapPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // trapPictureBox
            // 
            this.trapPictureBox.BackColor = System.Drawing.Color.White;
            this.trapPictureBox.Location = new System.Drawing.Point(12, 12);
            this.trapPictureBox.Name = "trapPictureBox";
            this.trapPictureBox.Size = new System.Drawing.Size(137, 129);
            this.trapPictureBox.TabIndex = 0;
            this.trapPictureBox.TabStop = false;
            this.trapPictureBox.Click += new System.EventHandler(this.trapPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(170, 158);
            this.Controls.Add(this.trapPictureBox);
            this.Name = "Form1";
            this.Text = "Trap";
            ((System.ComponentModel.ISupportInitialize)(this.trapPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox trapPictureBox;
    }
}

