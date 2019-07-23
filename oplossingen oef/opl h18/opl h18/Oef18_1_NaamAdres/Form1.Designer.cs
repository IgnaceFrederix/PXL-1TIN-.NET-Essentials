namespace Oef18_1_NaamAdres
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
            this.openenButton = new System.Windows.Forms.Button();
            this.opslaanButton = new System.Windows.Forms.Button();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openenButton
            // 
            this.openenButton.Location = new System.Drawing.Point(200, 155);
            this.openenButton.Name = "openenButton";
            this.openenButton.Size = new System.Drawing.Size(72, 23);
            this.openenButton.TabIndex = 9;
            this.openenButton.Text = "Openen";
            this.openenButton.Click += new System.EventHandler(this.openenButton_Click);
            // 
            // opslaanButton
            // 
            this.opslaanButton.Location = new System.Drawing.Point(122, 155);
            this.opslaanButton.Name = "opslaanButton";
            this.opslaanButton.Size = new System.Drawing.Size(72, 23);
            this.opslaanButton.TabIndex = 8;
            this.opslaanButton.Text = "Opslaan";
            this.opslaanButton.Click += new System.EventHandler(this.opslaanButton_Click);
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(12, 45);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.adresTextBox.Size = new System.Drawing.Size(260, 96);
            this.adresTextBox.TabIndex = 7;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(152, 23);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Naam + adres:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.openenButton);
            this.Controls.Add(this.opslaanButton);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.Label2);
            this.Name = "Form1";
            this.Text = "Oef 18.1 Naam en adres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button openenButton;
        internal System.Windows.Forms.Button opslaanButton;
        internal System.Windows.Forms.TextBox adresTextBox;
        internal System.Windows.Forms.Label Label2;
    }
}

