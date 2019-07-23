namespace Apartments
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
            this.apartmentsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // apartmentsPictureBox
            // 
            this.apartmentsPictureBox.BackColor = System.Drawing.Color.White;
            this.apartmentsPictureBox.Location = new System.Drawing.Point(12, 12);
            this.apartmentsPictureBox.Name = "apartmentsPictureBox";
            this.apartmentsPictureBox.Size = new System.Drawing.Size(171, 146);
            this.apartmentsPictureBox.TabIndex = 0;
            this.apartmentsPictureBox.TabStop = false;
            this.apartmentsPictureBox.Click += new System.EventHandler(this.apartmentsPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(197, 170);
            this.Controls.Add(this.apartmentsPictureBox);
            this.Name = "Form1";
            this.Text = "Apartments";
            ((System.ComponentModel.ISupportInitialize)(this.apartmentsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox apartmentsPictureBox;
    }
}

