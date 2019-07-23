namespace Oef2_1_Demo
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
            this.labelA = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelA.Location = new System.Drawing.Point(106, 16);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(160, 24);
            this.labelA.TabIndex = 9;
            this.labelA.Text = "A";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelB
            // 
            this.labelB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelB.Location = new System.Drawing.Point(106, 56);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(160, 24);
            this.labelB.TabIndex = 8;
            this.labelB.Text = "B";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelC
            // 
            this.labelC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelC.Location = new System.Drawing.Point(106, 96);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(160, 24);
            this.labelC.TabIndex = 7;
            this.labelC.Text = "C";
            this.labelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelC);
            this.Name = "Form1";
            this.Text = "Oef 2.1 Demo";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label labelA;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label labelB;
        internal System.Windows.Forms.Label labelC;
    }
}

