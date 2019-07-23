namespace Oef12_4_SomNGetallen
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
            this.lusLabel = new System.Windows.Forms.Label();
            this.formuleLabel = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lusLabel
            // 
            this.lusLabel.AutoSize = true;
            this.lusLabel.Location = new System.Drawing.Point(152, 128);
            this.lusLabel.Name = "lusLabel";
            this.lusLabel.Size = new System.Drawing.Size(39, 13);
            this.lusLabel.TabIndex = 10;
            this.lusLabel.Text = "Label4";
            // 
            // formuleLabel
            // 
            this.formuleLabel.AutoSize = true;
            this.formuleLabel.Location = new System.Drawing.Point(152, 75);
            this.formuleLabel.Name = "formuleLabel";
            this.formuleLabel.Size = new System.Drawing.Size(39, 13);
            this.formuleLabel.TabIndex = 11;
            this.formuleLabel.Text = "Label4";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(30, 128);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(24, 13);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Lus";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(30, 75);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 13);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "n (n + 1) / 2";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(155, 207);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 7;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.UseVisualStyleBackColor = true;
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(155, 21);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 20);
            this.nTextBox.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(30, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(104, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Geef waarde voor n:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lusLabel);
            this.Controls.Add(this.formuleLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 12.4 Som n getallen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lusLabel;
        internal System.Windows.Forms.Label formuleLabel;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.TextBox nTextBox;
        internal System.Windows.Forms.Label Label1;
    }
}

