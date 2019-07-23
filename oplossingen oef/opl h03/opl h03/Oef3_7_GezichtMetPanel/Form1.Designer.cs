namespace Oef3_7_GezichtMetPanel
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
            this.winkButton = new System.Windows.Forms.Button();
            this.helloButton = new System.Windows.Forms.Button();
            this.drawAreaPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            // drawAreaPanel
            // 
            this.drawAreaPanel.BackColor = System.Drawing.Color.White;
            this.drawAreaPanel.Location = new System.Drawing.Point(16, 45);
            this.drawAreaPanel.Name = "drawAreaPanel";
            this.drawAreaPanel.Size = new System.Drawing.Size(208, 216);
            this.drawAreaPanel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 273);
            this.Controls.Add(this.drawAreaPanel);
            this.Controls.Add(this.winkButton);
            this.Controls.Add(this.helloButton);
            this.Name = "Form1";
            this.Text = "Oef 3.7 Gezicht met Panel";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button winkButton;
        internal System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Panel drawAreaPanel;
    }
}

