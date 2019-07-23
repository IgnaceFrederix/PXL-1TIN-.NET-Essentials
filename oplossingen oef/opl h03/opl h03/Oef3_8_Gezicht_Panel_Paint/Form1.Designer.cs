namespace Oef3_8_Gezicht_Panel_Paint
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
            this.helloButton = new System.Windows.Forms.Button();
            this.drawAreaPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            this.drawAreaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawAreaPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 273);
            this.Controls.Add(this.drawAreaPanel);
            this.Controls.Add(this.helloButton);
            this.Name = "Form1";
            this.Text = "Oef 3.8 Gezicht Paint event";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button helloButton;
        private System.Windows.Forms.Panel drawAreaPanel;
    }
}

