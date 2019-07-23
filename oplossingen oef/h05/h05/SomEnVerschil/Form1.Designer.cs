namespace SomEnVerschil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.getal1TextBox = new System.Windows.Forms.TextBox();
            this.getal2TextBox = new System.Windows.Forms.TextBox();
            this.somLabel = new System.Windows.Forms.Label();
            this.verschilLabel = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eerste getal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tweede getal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Som";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Verschil";
            // 
            // getal1TextBox
            // 
            this.getal1TextBox.Location = new System.Drawing.Point(110, 44);
            this.getal1TextBox.Name = "getal1TextBox";
            this.getal1TextBox.Size = new System.Drawing.Size(162, 20);
            this.getal1TextBox.TabIndex = 1;
            // 
            // getal2TextBox
            // 
            this.getal2TextBox.Location = new System.Drawing.Point(110, 82);
            this.getal2TextBox.Name = "getal2TextBox";
            this.getal2TextBox.Size = new System.Drawing.Size(162, 20);
            this.getal2TextBox.TabIndex = 1;
            // 
            // somLabel
            // 
            this.somLabel.AutoSize = true;
            this.somLabel.Location = new System.Drawing.Point(107, 125);
            this.somLabel.Name = "somLabel";
            this.somLabel.Size = new System.Drawing.Size(52, 13);
            this.somLabel.TabIndex = 2;
            this.somLabel.Text = "somLabel";
            // 
            // verschilLabel
            // 
            this.verschilLabel.AutoSize = true;
            this.verschilLabel.Location = new System.Drawing.Point(107, 166);
            this.verschilLabel.Name = "verschilLabel";
            this.verschilLabel.Size = new System.Drawing.Size(69, 13);
            this.verschilLabel.TabIndex = 2;
            this.verschilLabel.Text = "verschilLabel";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(110, 205);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 3;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.UseVisualStyleBackColor = true;
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.verschilLabel);
            this.Controls.Add(this.somLabel);
            this.Controls.Add(this.getal2TextBox);
            this.Controls.Add(this.getal1TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Som en Verschil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox getal1TextBox;
        private System.Windows.Forms.TextBox getal2TextBox;
        private System.Windows.Forms.Label somLabel;
        private System.Windows.Forms.Label verschilLabel;
        private System.Windows.Forms.Button berekenButton;
    }
}

