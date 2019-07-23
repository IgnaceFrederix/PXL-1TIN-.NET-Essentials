namespace Oef14_17_Telefoongids
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
            this.voegToeButton = new System.Windows.Forms.Button();
            this.nummerTextBox = new System.Windows.Forms.TextBox();
            this.naamTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // zoekButton
            // 
            this.zoekButton.Location = new System.Drawing.Point(85, 180);
            this.zoekButton.Name = "zoekButton";
            this.zoekButton.Size = new System.Drawing.Size(75, 23);
            this.zoekButton.TabIndex = 9;
            this.zoekButton.Text = "Zoek";
            this.zoekButton.UseVisualStyleBackColor = true;
            this.zoekButton.Click += new System.EventHandler(this.zoekButton_Click);
            // 
            // voegToeButton
            // 
            this.voegToeButton.Location = new System.Drawing.Point(85, 133);
            this.voegToeButton.Name = "voegToeButton";
            this.voegToeButton.Size = new System.Drawing.Size(75, 23);
            this.voegToeButton.TabIndex = 8;
            this.voegToeButton.Text = "Voeg toe";
            this.voegToeButton.UseVisualStyleBackColor = true;
            this.voegToeButton.Click += new System.EventHandler(this.voegToeButton_Click);
            // 
            // nummerTextBox
            // 
            this.nummerTextBox.Location = new System.Drawing.Point(85, 95);
            this.nummerTextBox.Name = "nummerTextBox";
            this.nummerTextBox.Size = new System.Drawing.Size(178, 20);
            this.nummerTextBox.TabIndex = 7;
            // 
            // naamTextBox
            // 
            this.naamTextBox.Location = new System.Drawing.Point(85, 59);
            this.naamTextBox.Name = "naamTextBox";
            this.naamTextBox.Size = new System.Drawing.Size(178, 20);
            this.naamTextBox.TabIndex = 4;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 98);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Nummer:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 62);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Naam:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.zoekButton);
            this.Controls.Add(this.voegToeButton);
            this.Controls.Add(this.nummerTextBox);
            this.Controls.Add(this.naamTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 14.17 Telefoongids";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button zoekButton;
        internal System.Windows.Forms.Button voegToeButton;
        internal System.Windows.Forms.TextBox nummerTextBox;
        internal System.Windows.Forms.TextBox naamTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

