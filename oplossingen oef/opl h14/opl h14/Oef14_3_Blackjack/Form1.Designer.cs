namespace Oef14_3_Blackjack
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
            this.Label2 = new System.Windows.Forms.Label();
            this.nieuwButton = new System.Windows.Forms.Button();
            this.pasButton = new System.Windows.Forms.Button();
            this.kaartButton = new System.Windows.Forms.Button();
            this.computerLabel = new System.Windows.Forms.Label();
            this.kaartLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(3, 138);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 13);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Computer";
            // 
            // nieuwButton
            // 
            this.nieuwButton.Location = new System.Drawing.Point(126, 181);
            this.nieuwButton.Name = "nieuwButton";
            this.nieuwButton.Size = new System.Drawing.Size(75, 23);
            this.nieuwButton.TabIndex = 9;
            this.nieuwButton.Text = "Opnieuw";
            this.nieuwButton.UseVisualStyleBackColor = true;
            this.nieuwButton.Click += new System.EventHandler(this.nieuwButton_Click);
            // 
            // pasButton
            // 
            this.pasButton.Location = new System.Drawing.Point(197, 67);
            this.pasButton.Name = "pasButton";
            this.pasButton.Size = new System.Drawing.Size(75, 23);
            this.pasButton.TabIndex = 10;
            this.pasButton.Text = "Pas";
            this.pasButton.UseVisualStyleBackColor = true;
            this.pasButton.Click += new System.EventHandler(this.pasButton_Click);
            // 
            // kaartButton
            // 
            this.kaartButton.Location = new System.Drawing.Point(64, 67);
            this.kaartButton.Name = "kaartButton";
            this.kaartButton.Size = new System.Drawing.Size(75, 23);
            this.kaartButton.TabIndex = 8;
            this.kaartButton.Text = "Kaart";
            this.kaartButton.UseVisualStyleBackColor = true;
            this.kaartButton.Click += new System.EventHandler(this.kaartButton_Click);
            // 
            // computerLabel
            // 
            this.computerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.computerLabel.Location = new System.Drawing.Point(61, 133);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(211, 23);
            this.computerLabel.TabIndex = 6;
            this.computerLabel.Text = "Label2";
            this.computerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kaartLabel
            // 
            this.kaartLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.kaartLabel.Location = new System.Drawing.Point(61, 17);
            this.kaartLabel.Name = "kaartLabel";
            this.kaartLabel.Size = new System.Drawing.Size(211, 23);
            this.kaartLabel.TabIndex = 7;
            this.kaartLabel.Text = "Label2";
            this.kaartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "kaarten";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.nieuwButton);
            this.Controls.Add(this.pasButton);
            this.Controls.Add(this.kaartButton);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.kaartLabel);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 14.3 Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button nieuwButton;
        internal System.Windows.Forms.Button pasButton;
        internal System.Windows.Forms.Button kaartButton;
        internal System.Windows.Forms.Label computerLabel;
        internal System.Windows.Forms.Label kaartLabel;
        internal System.Windows.Forms.Label Label1;
    }
}

