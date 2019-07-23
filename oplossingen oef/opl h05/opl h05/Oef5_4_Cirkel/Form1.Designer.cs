namespace Oef5_4_Cirkel
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
            this.cirkelPictureBox = new System.Windows.Forms.PictureBox();
            this.tekenButton = new System.Windows.Forms.Button();
            this.straalTextBox = new System.Windows.Forms.TextBox();
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.mxTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cirkelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cirkelPictureBox
            // 
            this.cirkelPictureBox.BackColor = System.Drawing.Color.White;
            this.cirkelPictureBox.Location = new System.Drawing.Point(199, 12);
            this.cirkelPictureBox.Name = "cirkelPictureBox";
            this.cirkelPictureBox.Size = new System.Drawing.Size(256, 248);
            this.cirkelPictureBox.TabIndex = 15;
            this.cirkelPictureBox.TabStop = false;
            // 
            // tekenButton
            // 
            this.tekenButton.Location = new System.Drawing.Point(76, 237);
            this.tekenButton.Name = "tekenButton";
            this.tekenButton.Size = new System.Drawing.Size(75, 23);
            this.tekenButton.TabIndex = 14;
            this.tekenButton.Text = "Teken";
            this.tekenButton.Click += new System.EventHandler(this.tekenButton_Click);
            // 
            // straalTextBox
            // 
            this.straalTextBox.Location = new System.Drawing.Point(87, 108);
            this.straalTextBox.Name = "straalTextBox";
            this.straalTextBox.Size = new System.Drawing.Size(64, 20);
            this.straalTextBox.TabIndex = 13;
            // 
            // myTextBox
            // 
            this.myTextBox.Location = new System.Drawing.Point(87, 60);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(64, 20);
            this.myTextBox.TabIndex = 12;
            // 
            // mxTextBox
            // 
            this.mxTextBox.Location = new System.Drawing.Point(87, 12);
            this.mxTextBox.Name = "mxTextBox";
            this.mxTextBox.Size = new System.Drawing.Size(64, 20);
            this.mxTextBox.TabIndex = 11;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(7, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 24);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Middelpunt y:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(7, 108);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 24);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Straal:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(7, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 24);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Middelpunt x:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 278);
            this.Controls.Add(this.cirkelPictureBox);
            this.Controls.Add(this.tekenButton);
            this.Controls.Add(this.straalTextBox);
            this.Controls.Add(this.myTextBox);
            this.Controls.Add(this.mxTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 5.4 Cirkel";
            ((System.ComponentModel.ISupportInitialize)(this.cirkelPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox cirkelPictureBox;
        internal System.Windows.Forms.Button tekenButton;
        internal System.Windows.Forms.TextBox straalTextBox;
        internal System.Windows.Forms.TextBox myTextBox;
        internal System.Windows.Forms.TextBox mxTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
    }
}

