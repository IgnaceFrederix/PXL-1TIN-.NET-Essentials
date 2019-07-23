namespace Oef6_2_Ophogen
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
            this.verhoogButton = new System.Windows.Forms.Button();
            this.waardeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // verhoogButton
            // 
            this.verhoogButton.Location = new System.Drawing.Point(42, 90);
            this.verhoogButton.Name = "verhoogButton";
            this.verhoogButton.Size = new System.Drawing.Size(75, 23);
            this.verhoogButton.TabIndex = 3;
            this.verhoogButton.Text = "Verhoog";
            this.verhoogButton.Click += new System.EventHandler(this.verhoogButton_Click);
            // 
            // waardeLabel
            // 
            this.waardeLabel.Location = new System.Drawing.Point(42, 42);
            this.waardeLabel.Name = "waardeLabel";
            this.waardeLabel.Size = new System.Drawing.Size(100, 23);
            this.waardeLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 168);
            this.Controls.Add(this.verhoogButton);
            this.Controls.Add(this.waardeLabel);
            this.Name = "Form1";
            this.Text = "Oef 6.2 Ophogen";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button verhoogButton;
        internal System.Windows.Forms.Label waardeLabel;
    }
}

