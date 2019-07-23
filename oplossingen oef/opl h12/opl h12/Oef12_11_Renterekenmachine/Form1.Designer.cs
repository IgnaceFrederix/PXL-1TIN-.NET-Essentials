namespace Oef12_11_Renterekenmachine
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
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(21, 138);
            this.TextBox3.Multiline = true;
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox3.Size = new System.Drawing.Size(232, 112);
            this.TextBox3.TabIndex = 11;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(82, 95);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(96, 24);
            this.Button1.TabIndex = 10;
            this.Button1.Text = "Another year";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(189, 55);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(64, 20);
            this.TextBox2.TabIndex = 9;
            this.TextBox2.Text = "10";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(189, 15);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(64, 20);
            this.TextBox1.TabIndex = 8;
            this.TextBox1.Text = "100";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(18, 55);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(120, 32);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Enter interest rate:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(18, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 24);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Enter initial amount:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 12.11 Renterekenmachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

