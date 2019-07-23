namespace Oef5_16_TijdsverschilInSec
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
            this.Label4 = new System.Windows.Forms.Label();
            this.fTextBox = new System.Windows.Forms.TextBox();
            this.eTextBox = new System.Windows.Forms.TextBox();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.verschilButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(86, 15);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(192, 40);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "Geef tijdstip:";
            // 
            // fTextBox
            // 
            this.fTextBox.Location = new System.Drawing.Point(206, 159);
            this.fTextBox.Name = "fTextBox";
            this.fTextBox.Size = new System.Drawing.Size(100, 20);
            this.fTextBox.TabIndex = 22;
            // 
            // eTextBox
            // 
            this.eTextBox.Location = new System.Drawing.Point(206, 119);
            this.eTextBox.Name = "eTextBox";
            this.eTextBox.Size = new System.Drawing.Size(100, 20);
            this.eTextBox.TabIndex = 21;
            // 
            // dTextBox
            // 
            this.dTextBox.Location = new System.Drawing.Point(206, 79);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(100, 20);
            this.dTextBox.TabIndex = 20;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(22, 159);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(24, 23);
            this.Label3.TabIndex = 26;
            this.Label3.Text = "S:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(22, 119);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(24, 23);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "M:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(22, 79);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(24, 23);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "U:";
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(70, 159);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(100, 20);
            this.cTextBox.TabIndex = 19;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(70, 119);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 18;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(70, 79);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 20);
            this.aTextBox.TabIndex = 17;
            // 
            // verschilButton
            // 
            this.verschilButton.Location = new System.Drawing.Point(150, 199);
            this.verschilButton.Name = "verschilButton";
            this.verschilButton.Size = new System.Drawing.Size(75, 23);
            this.verschilButton.TabIndex = 23;
            this.verschilButton.Text = "Verschil";
            this.verschilButton.Click += new System.EventHandler(this.verschilButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 245);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.fTextBox);
            this.Controls.Add(this.eTextBox);
            this.Controls.Add(this.dTextBox);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.verschilButton);
            this.Name = "Form1";
            this.Text = "Oef 5.16 Tijdsverschil in sec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox fTextBox;
        internal System.Windows.Forms.TextBox eTextBox;
        internal System.Windows.Forms.TextBox dTextBox;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox cTextBox;
        internal System.Windows.Forms.TextBox bTextBox;
        internal System.Windows.Forms.TextBox aTextBox;
        internal System.Windows.Forms.Button verschilButton;
    }
}

