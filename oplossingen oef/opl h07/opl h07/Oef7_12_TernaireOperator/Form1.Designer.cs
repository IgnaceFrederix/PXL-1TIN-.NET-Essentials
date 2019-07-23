namespace Oef7_12_TernaireOperator
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
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxLeeftijd = new System.Windows.Forms.TextBox();
            this.ButtonBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(34, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 23);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Leeftijd:";
            // 
            // TextBoxLeeftijd
            // 
            this.TextBoxLeeftijd.Location = new System.Drawing.Point(82, 28);
            this.TextBoxLeeftijd.Name = "TextBoxLeeftijd";
            this.TextBoxLeeftijd.Size = new System.Drawing.Size(104, 20);
            this.TextBoxLeeftijd.TabIndex = 6;
            // 
            // ButtonBereken
            // 
            this.ButtonBereken.Location = new System.Drawing.Point(90, 68);
            this.ButtonBereken.Name = "ButtonBereken";
            this.ButtonBereken.Size = new System.Drawing.Size(75, 23);
            this.ButtonBereken.TabIndex = 7;
            this.ButtonBereken.Text = "&Bereken";
            this.ButtonBereken.Click += new System.EventHandler(this.ButtonBereken_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TextBoxLeeftijd);
            this.Controls.Add(this.ButtonBereken);
            this.Name = "Form1";
            this.Text = "Oef 7.12 Ternaire operator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TextBoxLeeftijd;
        internal System.Windows.Forms.Button ButtonBereken;
    }
}

