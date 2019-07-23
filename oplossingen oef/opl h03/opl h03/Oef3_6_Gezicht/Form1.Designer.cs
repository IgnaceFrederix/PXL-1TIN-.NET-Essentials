namespace Oef3_6_Gezicht
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
            this.drawAreaPictureBox = new System.Windows.Forms.PictureBox();
            this.winkButton = new System.Windows.Forms.Button();
            this.helloButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawAreaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawAreaPictureBox
            // 
            this.drawAreaPictureBox.BackColor = System.Drawing.Color.White;
            this.drawAreaPictureBox.Location = new System.Drawing.Point(13, 44);
            this.drawAreaPictureBox.Name = "drawAreaPictureBox";
            this.drawAreaPictureBox.Size = new System.Drawing.Size(208, 216);
            this.drawAreaPictureBox.TabIndex = 5;
            this.drawAreaPictureBox.TabStop = false;
            // 
            // winkButton
            // 
            this.winkButton.Location = new System.Drawing.Point(149, 12);
            this.winkButton.Name = "winkButton";
            this.winkButton.Size = new System.Drawing.Size(75, 23);
            this.winkButton.TabIndex = 4;
            this.winkButton.Text = "Knipoog!";
            this.winkButton.UseVisualStyleBackColor = true;
            this.winkButton.Click += new System.EventHandler(this.winkButton_Click);
            // 
            // helloButton
            // 
            this.helloButton.Location = new System.Drawing.Point(13, 12);
            this.helloButton.Name = "helloButton";
            this.helloButton.Size = new System.Drawing.Size(75, 23);
            this.helloButton.TabIndex = 3;
            this.helloButton.Text = "Hallo!";
            this.helloButton.UseVisualStyleBackColor = true;
            this.helloButton.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 273);
            this.Controls.Add(this.drawAreaPictureBox);
            this.Controls.Add(this.winkButton);
            this.Controls.Add(this.helloButton);
            this.Name = "Form1";
            this.Text = "Oef 3.6 Gezicht";
            ((System.ComponentModel.ISupportInitialize)(this.drawAreaPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox drawAreaPictureBox;
        internal System.Windows.Forms.Button winkButton;
        internal System.Windows.Forms.Button helloButton;
    }
}

