namespace Oef14_16_Ballonnen
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
            this.afstandTextBox = new System.Windows.Forms.TextBox();
            this.vergrootButton = new System.Windows.Forms.Button();
            this.verschuifButton = new System.Windows.Forms.Button();
            this.tekenButton = new System.Windows.Forms.Button();
            this.balloonsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.balloonsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // afstandTextBox
            // 
            this.afstandTextBox.Location = new System.Drawing.Point(57, 265);
            this.afstandTextBox.Name = "afstandTextBox";
            this.afstandTextBox.Size = new System.Drawing.Size(42, 20);
            this.afstandTextBox.TabIndex = 7;
            // 
            // vergrootButton
            // 
            this.vergrootButton.Location = new System.Drawing.Point(100, 292);
            this.vergrootButton.Name = "vergrootButton";
            this.vergrootButton.Size = new System.Drawing.Size(71, 24);
            this.vergrootButton.TabIndex = 6;
            this.vergrootButton.Text = "Vergroot";
            this.vergrootButton.Click += new System.EventHandler(this.vergrootButton_Click);
            // 
            // verschuifButton
            // 
            this.verschuifButton.Location = new System.Drawing.Point(100, 262);
            this.verschuifButton.Name = "verschuifButton";
            this.verschuifButton.Size = new System.Drawing.Size(71, 24);
            this.verschuifButton.TabIndex = 5;
            this.verschuifButton.Text = "Verschuif";
            this.verschuifButton.Click += new System.EventHandler(this.verschuifButton_Click);
            // 
            // tekenButton
            // 
            this.tekenButton.Location = new System.Drawing.Point(100, 228);
            this.tekenButton.Name = "tekenButton";
            this.tekenButton.Size = new System.Drawing.Size(71, 24);
            this.tekenButton.TabIndex = 4;
            this.tekenButton.Text = "Teken";
            this.tekenButton.Click += new System.EventHandler(this.tekenButton_Click);
            // 
            // balloonsPictureBox
            // 
            this.balloonsPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.balloonsPictureBox.Location = new System.Drawing.Point(12, 12);
            this.balloonsPictureBox.Name = "balloonsPictureBox";
            this.balloonsPictureBox.Size = new System.Drawing.Size(232, 208);
            this.balloonsPictureBox.TabIndex = 3;
            this.balloonsPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 332);
            this.Controls.Add(this.afstandTextBox);
            this.Controls.Add(this.vergrootButton);
            this.Controls.Add(this.verschuifButton);
            this.Controls.Add(this.tekenButton);
            this.Controls.Add(this.balloonsPictureBox);
            this.Name = "Form1";
            this.Text = "Oef 14.16 Ballonnen";
            ((System.ComponentModel.ISupportInitialize)(this.balloonsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox afstandTextBox;
        internal System.Windows.Forms.Button vergrootButton;
        internal System.Windows.Forms.Button verschuifButton;
        internal System.Windows.Forms.Button tekenButton;
        internal System.Windows.Forms.PictureBox balloonsPictureBox;
    }
}

