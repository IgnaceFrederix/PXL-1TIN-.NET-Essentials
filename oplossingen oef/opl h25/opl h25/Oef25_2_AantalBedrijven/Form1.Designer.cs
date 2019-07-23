namespace Oef25_2_AantalBedrijven
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
            this.aantalV2Button = new System.Windows.Forms.Button();
            this.aantalV1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aantalV2Button
            // 
            this.aantalV2Button.Location = new System.Drawing.Point(98, 100);
            this.aantalV2Button.Name = "aantalV2Button";
            this.aantalV2Button.Size = new System.Drawing.Size(75, 23);
            this.aantalV2Button.TabIndex = 3;
            this.aantalV2Button.Text = "Aantal v2";
            this.aantalV2Button.UseVisualStyleBackColor = true;
            this.aantalV2Button.Click += new System.EventHandler(this.aantalV2Button_Click);
            // 
            // aantalV1Button
            // 
            this.aantalV1Button.Location = new System.Drawing.Point(98, 46);
            this.aantalV1Button.Name = "aantalV1Button";
            this.aantalV1Button.Size = new System.Drawing.Size(75, 23);
            this.aantalV1Button.TabIndex = 2;
            this.aantalV1Button.Text = "Aantal v1";
            this.aantalV1Button.UseVisualStyleBackColor = true;
            this.aantalV1Button.Click += new System.EventHandler(this.aantalV1Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.aantalV2Button);
            this.Controls.Add(this.aantalV1Button);
            this.Name = "Form1";
            this.Text = "Oef 25.2 Aantal bedrijven";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button aantalV2Button;
        internal System.Windows.Forms.Button aantalV1Button;
    }
}

