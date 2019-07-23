namespace Oef12_8_Opp_Driehoek
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
            this.berekenButton = new System.Windows.Forms.Button();
            this.oppLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.bTextBoxtxt = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(71, 228);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 13;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.UseVisualStyleBackColor = true;
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // oppLabel
            // 
            this.oppLabel.AutoSize = true;
            this.oppLabel.Location = new System.Drawing.Point(68, 136);
            this.oppLabel.Name = "oppLabel";
            this.oppLabel.Size = new System.Drawing.Size(39, 13);
            this.oppLabel.TabIndex = 12;
            this.oppLabel.Text = "Label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Opp";
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(71, 89);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(100, 20);
            this.cTextBox.TabIndex = 10;
            // 
            // bTextBoxtxt
            // 
            this.bTextBoxtxt.Location = new System.Drawing.Point(71, 57);
            this.bTextBoxtxt.Name = "bTextBoxtxt";
            this.bTextBoxtxt.Size = new System.Drawing.Size(100, 20);
            this.bTextBoxtxt.TabIndex = 9;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(71, 26);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 20);
            this.aTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 276);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.oppLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.bTextBoxtxt);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Oef 12.8 Opp driehoek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.Label oppLabel;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox cTextBox;
        internal System.Windows.Forms.TextBox bTextBoxtxt;
        internal System.Windows.Forms.TextBox aTextBox;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
    }
}

