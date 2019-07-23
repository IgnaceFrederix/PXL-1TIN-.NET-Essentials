namespace Oef7_1_KaartDelen
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
            this.kaartTextBox = new System.Windows.Forms.TextBox();
            this.kaartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kaartTextBox
            // 
            this.kaartTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaartTextBox.Location = new System.Drawing.Point(8, 68);
            this.kaartTextBox.Name = "kaartTextBox";
            this.kaartTextBox.Size = new System.Drawing.Size(264, 38);
            this.kaartTextBox.TabIndex = 7;
            this.kaartTextBox.Text = "Kaart";
            this.kaartTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // kaartButton
            // 
            this.kaartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaartButton.Location = new System.Drawing.Point(8, 12);
            this.kaartButton.Name = "kaartButton";
            this.kaartButton.Size = new System.Drawing.Size(264, 48);
            this.kaartButton.TabIndex = 6;
            this.kaartButton.Text = "Trek een kaart !";
            this.kaartButton.Click += new System.EventHandler(this.kaartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.kaartTextBox);
            this.Controls.Add(this.kaartButton);
            this.Name = "Form1";
            this.Text = "Oef 7.1 Kaart delen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox kaartTextBox;
        internal System.Windows.Forms.Button kaartButton;
    }
}

