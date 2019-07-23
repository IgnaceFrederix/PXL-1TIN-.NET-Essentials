namespace Oef12_7_Belastingberekening
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
            this.LabelBelasting = new System.Windows.Forms.Label();
            this.belastingButton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.inkomenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelBelasting
            // 
            this.LabelBelasting.Location = new System.Drawing.Point(150, 140);
            this.LabelBelasting.Name = "LabelBelasting";
            this.LabelBelasting.Size = new System.Drawing.Size(100, 23);
            this.LabelBelasting.TabIndex = 9;
            // 
            // belastingButton
            // 
            this.belastingButton.Location = new System.Drawing.Point(22, 140);
            this.belastingButton.Name = "belastingButton";
            this.belastingButton.Size = new System.Drawing.Size(112, 23);
            this.belastingButton.TabIndex = 8;
            this.belastingButton.Text = "Bereken belasting";
            this.belastingButton.Click += new System.EventHandler(this.belastingButton_Click);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(22, 92);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 23);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Geef inkomen:";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(22, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(240, 40);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Belastingberekening";
            // 
            // inkomenTextBox
            // 
            this.inkomenTextBox.Location = new System.Drawing.Point(108, 89);
            this.inkomenTextBox.Name = "inkomenTextBox";
            this.inkomenTextBox.Size = new System.Drawing.Size(100, 20);
            this.inkomenTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.LabelBelasting);
            this.Controls.Add(this.belastingButton);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.inkomenTextBox);
            this.Name = "Form1";
            this.Text = "Oef 12.7 Belastingberekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LabelBelasting;
        internal System.Windows.Forms.Button belastingButton;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox inkomenTextBox;
    }
}

