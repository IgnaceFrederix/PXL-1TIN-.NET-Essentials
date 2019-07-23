namespace Oef25_1_LokatieBedrijf
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
            this.zoekButton = new System.Windows.Forms.Button();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zoekButton
            // 
            this.zoekButton.Location = new System.Drawing.Point(270, 10);
            this.zoekButton.Name = "zoekButton";
            this.zoekButton.Size = new System.Drawing.Size(75, 23);
            this.zoekButton.TabIndex = 5;
            this.zoekButton.Text = "Zoek";
            this.zoekButton.UseVisualStyleBackColor = true;
            this.zoekButton.Click += new System.EventHandler(this.zoekButton_Click);
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(76, 12);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(188, 20);
            this.naamTextBox.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(4, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Naam bedrijf:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 56);
            this.Controls.Add(this.zoekButton);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 25.1 Lokatie bedrijf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button zoekButton;
        internal System.Windows.Forms.TextBox naamTextBox;
        internal System.Windows.Forms.Label Label1;
    }
}

