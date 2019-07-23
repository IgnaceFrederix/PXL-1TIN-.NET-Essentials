namespace Oef5_17_UMSVerschil
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
            this.sec2TextBox = new System.Windows.Forms.TextBox();
            this.sec1TextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.verschilButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sec2TextBox
            // 
            this.sec2TextBox.Location = new System.Drawing.Point(310, 116);
            this.sec2TextBox.Name = "sec2TextBox";
            this.sec2TextBox.Size = new System.Drawing.Size(100, 20);
            this.sec2TextBox.TabIndex = 5;
            // 
            // sec1TextBox
            // 
            this.sec1TextBox.Location = new System.Drawing.Point(166, 116);
            this.sec1TextBox.Name = "sec1TextBox";
            this.sec1TextBox.Size = new System.Drawing.Size(100, 20);
            this.sec1TextBox.TabIndex = 3;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(54, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(456, 40);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Geef 2 tijdstippen in seconden";
            // 
            // verschilButton
            // 
            this.verschilButton.Location = new System.Drawing.Point(230, 188);
            this.verschilButton.Name = "verschilButton";
            this.verschilButton.Size = new System.Drawing.Size(120, 23);
            this.verschilButton.TabIndex = 6;
            this.verschilButton.Text = "Verschil in U:M:S";
            this.verschilButton.Click += new System.EventHandler(this.verschilButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 262);
            this.Controls.Add(this.sec2TextBox);
            this.Controls.Add(this.sec1TextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.verschilButton);
            this.Name = "Form1";
            this.Text = "Oef 5.17 UMS Verschil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox sec2TextBox;
        internal System.Windows.Forms.TextBox sec1TextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button verschilButton;
    }
}

