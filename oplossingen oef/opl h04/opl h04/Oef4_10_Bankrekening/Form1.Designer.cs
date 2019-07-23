namespace Oef4_10_Bankrekening
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
            this.renteTextBox = new System.Windows.Forms.TextBox();
            this.aantalTextBox = new System.Windows.Forms.TextBox();
            this.beginTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.berekenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // renteTextBox
            // 
            this.renteTextBox.Location = new System.Drawing.Point(144, 132);
            this.renteTextBox.Name = "renteTextBox";
            this.renteTextBox.Size = new System.Drawing.Size(100, 20);
            this.renteTextBox.TabIndex = 8;
            // 
            // aantalTextBox
            // 
            this.aantalTextBox.Location = new System.Drawing.Point(144, 84);
            this.aantalTextBox.Name = "aantalTextBox";
            this.aantalTextBox.Size = new System.Drawing.Size(100, 20);
            this.aantalTextBox.TabIndex = 6;
            // 
            // beginTextBox
            // 
            this.beginTextBox.Location = new System.Drawing.Point(144, 36);
            this.beginTextBox.Name = "beginTextBox";
            this.beginTextBox.Size = new System.Drawing.Size(100, 20);
            this.beginTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(40, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rente per jaar:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aantal jaren:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Beginsaldo:";
            // 
            // berekenButton
            // 
            this.berekenButton.Location = new System.Drawing.Point(80, 204);
            this.berekenButton.Name = "berekenButton";
            this.berekenButton.Size = new System.Drawing.Size(112, 23);
            this.berekenButton.TabIndex = 9;
            this.berekenButton.Text = "Bereken eindsaldo";
            this.berekenButton.Click += new System.EventHandler(this.berekenButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.renteTextBox);
            this.Controls.Add(this.aantalTextBox);
            this.Controls.Add(this.beginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.berekenButton);
            this.Name = "Form1";
            this.Text = "Oef 4.10 Bankrekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox renteTextBox;
        internal System.Windows.Forms.TextBox aantalTextBox;
        internal System.Windows.Forms.TextBox beginTextBox;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button berekenButton;
    }
}

