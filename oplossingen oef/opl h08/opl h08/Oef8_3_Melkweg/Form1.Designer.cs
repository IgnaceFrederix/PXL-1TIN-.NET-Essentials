namespace Oef8_3_Melkweg
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
            this.hemelPictureBox = new System.Windows.Forms.PictureBox();
            this.melkwegButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hemelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // hemelPictureBox
            // 
            this.hemelPictureBox.Location = new System.Drawing.Point(20, 66);
            this.hemelPictureBox.Name = "hemelPictureBox";
            this.hemelPictureBox.Size = new System.Drawing.Size(928, 536);
            this.hemelPictureBox.TabIndex = 3;
            this.hemelPictureBox.TabStop = false;
            // 
            // melkwegButton
            // 
            this.melkwegButton.BackColor = System.Drawing.Color.Yellow;
            this.melkwegButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.melkwegButton.Location = new System.Drawing.Point(332, 10);
            this.melkwegButton.Name = "melkwegButton";
            this.melkwegButton.Size = new System.Drawing.Size(272, 48);
            this.melkwegButton.TabIndex = 2;
            this.melkwegButton.Text = "De melkweg";
            this.melkwegButton.UseVisualStyleBackColor = false;
            this.melkwegButton.Click += new System.EventHandler(this.melkwegButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(968, 613);
            this.Controls.Add(this.hemelPictureBox);
            this.Controls.Add(this.melkwegButton);
            this.Name = "Form1";
            this.Text = "Oef 8.3 De melkweg";
            ((System.ComponentModel.ISupportInitialize)(this.hemelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox hemelPictureBox;
        internal System.Windows.Forms.Button melkwegButton;
    }
}

