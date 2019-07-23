namespace Oef17_5_SamengesteldeIntrest
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
            this.looptijdTextBox = new System.Windows.Forms.TextBox();
            this.renteTextBox = new System.Windows.Forms.TextBox();
            this.beginSaldoTextBox = new System.Windows.Forms.TextBox();
            this.eindSaldoLabel = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(191, 227);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 3;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.UseVisualStyleBackColor = true;
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // looptijdTextBox
            // 
            this.looptijdTextBox.Location = new System.Drawing.Point(116, 83);
            this.looptijdTextBox.Name = "looptijdTextBox";
            this.looptijdTextBox.Size = new System.Drawing.Size(150, 20);
            this.looptijdTextBox.TabIndex = 2;
            // 
            // renteTextBox
            // 
            this.renteTextBox.Location = new System.Drawing.Point(116, 52);
            this.renteTextBox.Name = "renteTextBox";
            this.renteTextBox.Size = new System.Drawing.Size(150, 20);
            this.renteTextBox.TabIndex = 1;
            // 
            // beginSaldoTextBox
            // 
            this.beginSaldoTextBox.Location = new System.Drawing.Point(116, 21);
            this.beginSaldoTextBox.Name = "beginSaldoTextBox";
            this.beginSaldoTextBox.Size = new System.Drawing.Size(150, 20);
            this.beginSaldoTextBox.TabIndex = 0;
            // 
            // eindSaldoLabel
            // 
            this.eindSaldoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.eindSaldoLabel.Location = new System.Drawing.Point(119, 148);
            this.eindSaldoLabel.Name = "eindSaldoLabel";
            this.eindSaldoLabel.Size = new System.Drawing.Size(147, 23);
            this.eindSaldoLabel.TabIndex = 7;
            this.eindSaldoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(18, 153);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 13);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Eindsaldo";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(18, 86);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(44, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Looptijd";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 13);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Rente per jaar";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Beginsaldo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.looptijdTextBox);
            this.Controls.Add(this.renteTextBox);
            this.Controls.Add(this.beginSaldoTextBox);
            this.Controls.Add(this.eindSaldoLabel);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 17.5 Samengestelde intrest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.TextBox looptijdTextBox;
        internal System.Windows.Forms.TextBox renteTextBox;
        internal System.Windows.Forms.TextBox beginSaldoTextBox;
        internal System.Windows.Forms.Label eindSaldoLabel;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

