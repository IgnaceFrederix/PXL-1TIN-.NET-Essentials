namespace Oef16_1_Samenvoegen
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
            this.samenLabel = new System.Windows.Forms.Label();
            this.samenButton = new System.Windows.Forms.Button();
            this.woord2TextBox = new System.Windows.Forms.TextBox();
            this.woord1TextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // samenLabel
            // 
            this.samenLabel.AutoSize = true;
            this.samenLabel.Location = new System.Drawing.Point(8, 151);
            this.samenLabel.Name = "samenLabel";
            this.samenLabel.Size = new System.Drawing.Size(39, 13);
            this.samenLabel.TabIndex = 9;
            this.samenLabel.Text = "Label3";
            // 
            // samenButton
            // 
            this.samenButton.Location = new System.Drawing.Point(95, 87);
            this.samenButton.Name = "samenButton";
            this.samenButton.Size = new System.Drawing.Size(75, 23);
            this.samenButton.TabIndex = 8;
            this.samenButton.Text = "Voeg samen";
            this.samenButton.UseVisualStyleBackColor = true;
            this.samenButton.Click += new System.EventHandler(this.samenButton_Click);
            // 
            // woord2TextBox
            // 
            this.woord2TextBox.Location = new System.Drawing.Point(70, 46);
            this.woord2TextBox.Name = "woord2TextBox";
            this.woord2TextBox.Size = new System.Drawing.Size(100, 20);
            this.woord2TextBox.TabIndex = 7;
            // 
            // woord1TextBox
            // 
            this.woord1TextBox.Location = new System.Drawing.Point(70, 12);
            this.woord1TextBox.Name = "woord1TextBox";
            this.woord1TextBox.Size = new System.Drawing.Size(100, 20);
            this.woord1TextBox.TabIndex = 6;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 49);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Woord 2:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Woord 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 196);
            this.Controls.Add(this.samenLabel);
            this.Controls.Add(this.samenButton);
            this.Controls.Add(this.woord2TextBox);
            this.Controls.Add(this.woord1TextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 16.1 Samenvoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label samenLabel;
        internal System.Windows.Forms.Button samenButton;
        internal System.Windows.Forms.TextBox woord2TextBox;
        internal System.Windows.Forms.TextBox woord1TextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

