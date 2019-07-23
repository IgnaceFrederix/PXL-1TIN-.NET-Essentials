namespace Oef6_3_Random_Som_Gemiddelde
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
            this.generateButton = new System.Windows.Forms.Button();
            this.gemiddeldeTextbox = new System.Windows.Forms.TextBox();
            this.somTextbox = new System.Windows.Forms.TextBox();
            this.randomTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(109, 178);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 13;
            this.generateButton.Text = "Genereer";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // gemiddeldeTextbox
            // 
            this.gemiddeldeTextbox.Location = new System.Drawing.Point(157, 136);
            this.gemiddeldeTextbox.Name = "gemiddeldeTextbox";
            this.gemiddeldeTextbox.ReadOnly = true;
            this.gemiddeldeTextbox.Size = new System.Drawing.Size(100, 20);
            this.gemiddeldeTextbox.TabIndex = 12;
            // 
            // somTextbox
            // 
            this.somTextbox.Location = new System.Drawing.Point(157, 100);
            this.somTextbox.Name = "somTextbox";
            this.somTextbox.ReadOnly = true;
            this.somTextbox.Size = new System.Drawing.Size(100, 20);
            this.somTextbox.TabIndex = 11;
            // 
            // randomTextbox
            // 
            this.randomTextbox.Location = new System.Drawing.Point(157, 62);
            this.randomTextbox.Name = "randomTextbox";
            this.randomTextbox.PasswordChar = '*';
            this.randomTextbox.ReadOnly = true;
            this.randomTextbox.Size = new System.Drawing.Size(100, 20);
            this.randomTextbox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lopend gemiddelde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lopende som";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Random getal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.gemiddeldeTextbox);
            this.Controls.Add(this.somTextbox);
            this.Controls.Add(this.randomTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Oef 6.3 Random Som Gemiddelde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button generateButton;
        internal System.Windows.Forms.TextBox gemiddeldeTextbox;
        internal System.Windows.Forms.TextBox somTextbox;
        internal System.Windows.Forms.TextBox randomTextbox;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
    }
}

