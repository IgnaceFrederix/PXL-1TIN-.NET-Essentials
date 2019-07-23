namespace Oef15_7_ConwaySpel
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
            this.nextButton = new System.Windows.Forms.Button();
            this.bordPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bordPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(432, 12);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(52, 23);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // bordPictureBox
            // 
            this.bordPictureBox.BackColor = System.Drawing.Color.Silver;
            this.bordPictureBox.Location = new System.Drawing.Point(12, 12);
            this.bordPictureBox.Name = "bordPictureBox";
            this.bordPictureBox.Size = new System.Drawing.Size(401, 401);
            this.bordPictureBox.TabIndex = 2;
            this.bordPictureBox.TabStop = false;
            this.bordPictureBox.Click += new System.EventHandler(this.pbBord_Click);
            this.bordPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pbBord_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 428);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.bordPictureBox);
            this.Name = "Form1";
            this.Text = "Oef 15.7 Conway\'s levensspel";
            ((System.ComponentModel.ISupportInitialize)(this.bordPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button nextButton;
        internal System.Windows.Forms.PictureBox bordPictureBox;
    }
}

