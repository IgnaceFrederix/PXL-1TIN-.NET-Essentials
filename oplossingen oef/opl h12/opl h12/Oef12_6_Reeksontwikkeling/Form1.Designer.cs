namespace Oef12_6_Reeksontwikkeling
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
            this.iteratiesLabel = new System.Windows.Forms.Label();
            this.eLabel = new System.Windows.Forms.Label();
            this.berekeningLabel = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.nauwkTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iteratiesLabel
            // 
            this.iteratiesLabel.AutoSize = true;
            this.iteratiesLabel.Location = new System.Drawing.Point(277, 94);
            this.iteratiesLabel.Name = "iteratiesLabel";
            this.iteratiesLabel.Size = new System.Drawing.Size(39, 13);
            this.iteratiesLabel.TabIndex = 13;
            this.iteratiesLabel.Text = "Label5";
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(125, 141);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(39, 13);
            this.eLabel.TabIndex = 14;
            this.eLabel.Text = "Label5";
            // 
            // berekeningLabel
            // 
            this.berekeningLabel.AutoSize = true;
            this.berekeningLabel.Location = new System.Drawing.Point(125, 94);
            this.berekeningLabel.Name = "berekeningLabel";
            this.berekeningLabel.Size = new System.Drawing.Size(39, 13);
            this.berekeningLabel.TabIndex = 15;
            this.berekeningLabel.Text = "Label5";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(182, 207);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 12;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.UseVisualStyleBackColor = true;
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(55, 141);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(61, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "met Math.E";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(210, 94);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(47, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Iteraties:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(55, 94);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Berekening:";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(280, 33);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 20);
            this.xTextBox.TabIndex = 7;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(55, 36);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(45, 13);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Getal X:";
            // 
            // nauwkTextBox
            // 
            this.nauwkTextBox.Location = new System.Drawing.Point(280, 59);
            this.nauwkTextBox.Name = "nauwkTextBox";
            this.nauwkTextBox.Size = new System.Drawing.Size(100, 20);
            this.nauwkTextBox.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(55, 62);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(219, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Nauwkeurigheid (aantal cijfers na de komma)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 262);
            this.Controls.Add(this.iteratiesLabel);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.berekeningLabel);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.nauwkTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 12.6 Reeksontwikkeling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label iteratiesLabel;
        internal System.Windows.Forms.Label eLabel;
        internal System.Windows.Forms.Label berekeningLabel;
        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox xTextBox;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox nauwkTextBox;
        internal System.Windows.Forms.Label Label1;
    }
}

