namespace Oef7_13_BTW_Tarief
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
            this.nettoTextBox = new System.Windows.Forms.TextBox();
            this.totaalLabel = new System.Windows.Forms.Label();
            this.BTWLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.tariefCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nettoTextBox
            // 
            this.nettoTextBox.Location = new System.Drawing.Point(92, 29);
            this.nettoTextBox.Name = "nettoTextBox";
            this.nettoTextBox.Size = new System.Drawing.Size(178, 20);
            this.nettoTextBox.TabIndex = 16;
            // 
            // totaalLabel
            // 
            this.totaalLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totaalLabel.Location = new System.Drawing.Point(90, 154);
            this.totaalLabel.Name = "totaalLabel";
            this.totaalLabel.Size = new System.Drawing.Size(178, 23);
            this.totaalLabel.TabIndex = 15;
            // 
            // BTWLabel
            // 
            this.BTWLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTWLabel.Location = new System.Drawing.Point(89, 117);
            this.BTWLabel.Name = "BTWLabel";
            this.BTWLabel.Size = new System.Drawing.Size(178, 23);
            this.BTWLabel.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Totaal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "BTW";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(92, 205);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 11;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.UseVisualStyleBackColor = true;
            this.berekenButton.Click += new System.EventHandler(this.BerekenButton_Click);
            // 
            // tariefCheckBox
            // 
            this.tariefCheckBox.AutoSize = true;
            this.tariefCheckBox.Location = new System.Drawing.Point(92, 57);
            this.tariefCheckBox.Name = "tariefCheckBox";
            this.tariefCheckBox.Size = new System.Drawing.Size(94, 17);
            this.tariefCheckBox.TabIndex = 10;
            this.tariefCheckBox.Text = "Verlaagd tarief";
            this.tariefCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Netto prijs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 242);
            this.Controls.Add(this.nettoTextBox);
            this.Controls.Add(this.totaalLabel);
            this.Controls.Add(this.BTWLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.tariefCheckBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Oef 7.13: BTW Tarief";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox nettoTextBox;
        internal System.Windows.Forms.Label totaalLabel;
        internal System.Windows.Forms.Label BTWLabel;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.CheckBox tariefCheckBox;
        internal System.Windows.Forms.Label label1;
    }
}

