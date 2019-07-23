namespace Balloons
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
            this.balloonsPictureBox = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.balloonsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // balloonsPictureBox
            // 
            this.balloonsPictureBox.BackColor = System.Drawing.Color.White;
            this.balloonsPictureBox.Location = new System.Drawing.Point(12, 12);
            this.balloonsPictureBox.Name = "balloonsPictureBox";
            this.balloonsPictureBox.Size = new System.Drawing.Size(260, 207);
            this.balloonsPictureBox.TabIndex = 0;
            this.balloonsPictureBox.TabStop = false;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(101, 227);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.balloonsPictureBox);
            this.Name = "Form1";
            this.Text = "Balloons";
            ((System.ComponentModel.ISupportInitialize)(this.balloonsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox balloonsPictureBox;
        private System.Windows.Forms.Button drawButton;
    }
}

