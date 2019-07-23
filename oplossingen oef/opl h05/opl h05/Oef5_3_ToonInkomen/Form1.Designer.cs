namespace Oef5_3_ToonInkomen
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
            this.aantalJarenTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.jaarSalarisTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aantalJarenTextBox
            // 
            this.aantalJarenTextBox.Location = new System.Drawing.Point(152, 66);
            this.aantalJarenTextBox.Name = "aantalJarenTextBox";
            this.aantalJarenTextBox.Size = new System.Drawing.Size(100, 20);
            this.aantalJarenTextBox.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(32, 66);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 23);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Aantal jaren gewerkt:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(32, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 23);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Jaarsalaris:";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(152, 114);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(75, 23);
            this.berekenButton.TabIndex = 7;
            this.berekenButton.Text = "Bereken";
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // jaarSalarisTextBox
            // 
            this.jaarSalarisTextBox.Location = new System.Drawing.Point(152, 26);
            this.jaarSalarisTextBox.Name = "jaarSalarisTextBox";
            this.jaarSalarisTextBox.Size = new System.Drawing.Size(100, 20);
            this.jaarSalarisTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.aantalJarenTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.berekenButton);
            this.Controls.Add(this.jaarSalarisTextBox);
            this.Name = "Form1";
            this.Text = "Oef 5.3 Toon inkomen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox aantalJarenTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button berekenButton;
        internal System.Windows.Forms.TextBox jaarSalarisTextBox;
    }
}

