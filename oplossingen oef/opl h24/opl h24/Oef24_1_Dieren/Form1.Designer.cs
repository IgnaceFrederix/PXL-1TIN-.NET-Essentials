namespace Oef24_1_Dieren
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
            this.varkenButton = new System.Windows.Forms.Button();
            this.slangButton = new System.Windows.Forms.Button();
            this.koeButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // varkenButton
            // 
            this.varkenButton.Location = new System.Drawing.Point(95, 191);
            this.varkenButton.Name = "varkenButton";
            this.varkenButton.Size = new System.Drawing.Size(75, 23);
            this.varkenButton.TabIndex = 9;
            this.varkenButton.Text = "Varken";
            this.varkenButton.UseVisualStyleBackColor = true;
            this.varkenButton.Click += new System.EventHandler(this.varkenButton_Click);
            // 
            // slangButton
            // 
            this.slangButton.Location = new System.Drawing.Point(95, 145);
            this.slangButton.Name = "slangButton";
            this.slangButton.Size = new System.Drawing.Size(75, 23);
            this.slangButton.TabIndex = 8;
            this.slangButton.Text = "Slang";
            this.slangButton.UseVisualStyleBackColor = true;
            this.slangButton.Click += new System.EventHandler(this.slangButton_Click);
            // 
            // koeButton
            // 
            this.koeButton.Location = new System.Drawing.Point(95, 102);
            this.koeButton.Name = "koeButton";
            this.koeButton.Size = new System.Drawing.Size(75, 23);
            this.koeButton.TabIndex = 7;
            this.koeButton.Text = "Koe";
            this.koeButton.UseVisualStyleBackColor = true;
            this.koeButton.Click += new System.EventHandler(this.koeButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(29, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(28, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Info:";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(95, 49);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(161, 20);
            this.infoTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.varkenButton);
            this.Controls.Add(this.slangButton);
            this.Controls.Add(this.koeButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.infoTextBox);
            this.Name = "Form1";
            this.Text = "Oef 24.1 Dieren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button varkenButton;
        internal System.Windows.Forms.Button slangButton;
        internal System.Windows.Forms.Button koeButton;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox infoTextBox;
    }
}

