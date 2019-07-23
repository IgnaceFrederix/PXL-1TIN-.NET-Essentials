namespace Oef4_8_Weerstanden
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
            this.toonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toonButton
            // 
            this.toonButton.Location = new System.Drawing.Point(96, 49);
            this.toonButton.Name = "toonButton";
            this.toonButton.Size = new System.Drawing.Size(75, 23);
            this.toonButton.TabIndex = 0;
            this.toonButton.Text = "Toon";
            this.toonButton.UseVisualStyleBackColor = true;
            this.toonButton.Click += new System.EventHandler(this.toonButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.toonButton);
            this.Name = "Form1";
            this.Text = "Oef 4.8 Weerstanden";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toonButton;
    }
}

