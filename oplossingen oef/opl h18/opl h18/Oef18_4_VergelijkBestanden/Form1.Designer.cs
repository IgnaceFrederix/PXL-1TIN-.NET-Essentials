namespace Oef18_4_VergelijkBestanden
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
            this.resultLabel = new System.Windows.Forms.Label();
            this.compareButton = new System.Windows.Forms.Button();
            this.browse2Button = new System.Windows.Forms.Button();
            this.LabelFile2 = new System.Windows.Forms.Label();
            this.file2TextBox = new System.Windows.Forms.TextBox();
            this.browse1Button = new System.Windows.Forms.Button();
            this.LabelFile1 = new System.Windows.Forms.Label();
            this.file1TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Arial", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(39, 258);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(656, 120);
            this.resultLabel.TabIndex = 15;
            this.resultLabel.Text = "Equal / Differ";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compareButton
            // 
            this.compareButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compareButton.Location = new System.Drawing.Point(191, 154);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(296, 56);
            this.compareButton.TabIndex = 14;
            this.compareButton.Text = "COMPARE";
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // browse2Button
            // 
            this.browse2Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse2Button.Location = new System.Drawing.Point(607, 106);
            this.browse2Button.Name = "browse2Button";
            this.browse2Button.Size = new System.Drawing.Size(88, 26);
            this.browse2Button.TabIndex = 13;
            this.browse2Button.Text = "Browse 2";
            this.browse2Button.Click += new System.EventHandler(this.browse2Button_Click);
            // 
            // LabelFile2
            // 
            this.LabelFile2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFile2.Location = new System.Drawing.Point(31, 82);
            this.LabelFile2.Name = "LabelFile2";
            this.LabelFile2.Size = new System.Drawing.Size(192, 16);
            this.LabelFile2.TabIndex = 12;
            this.LabelFile2.Text = "File 2:";
            // 
            // file2TextBox
            // 
            this.file2TextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file2TextBox.Location = new System.Drawing.Point(31, 106);
            this.file2TextBox.Name = "file2TextBox";
            this.file2TextBox.Size = new System.Drawing.Size(552, 26);
            this.file2TextBox.TabIndex = 11;
            this.file2TextBox.Text = "File 2";
            this.file2TextBox.TextChanged += new System.EventHandler(this.TextBoxFile2_TextChanged);
            // 
            // browse1Button
            // 
            this.browse1Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse1Button.Location = new System.Drawing.Point(607, 42);
            this.browse1Button.Name = "browse1Button";
            this.browse1Button.Size = new System.Drawing.Size(88, 26);
            this.browse1Button.TabIndex = 10;
            this.browse1Button.Text = "Browse 1";
            this.browse1Button.Click += new System.EventHandler(this.browse1Button_Click);
            // 
            // LabelFile1
            // 
            this.LabelFile1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFile1.Location = new System.Drawing.Point(31, 18);
            this.LabelFile1.Name = "LabelFile1";
            this.LabelFile1.Size = new System.Drawing.Size(192, 16);
            this.LabelFile1.TabIndex = 9;
            this.LabelFile1.Text = "File 1:";
            // 
            // file1TextBox
            // 
            this.file1TextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file1TextBox.Location = new System.Drawing.Point(31, 42);
            this.file1TextBox.Name = "file1TextBox";
            this.file1TextBox.Size = new System.Drawing.Size(552, 26);
            this.file1TextBox.TabIndex = 8;
            this.file1TextBox.Text = "File 1";
            this.file1TextBox.TextChanged += new System.EventHandler(this.TextBoxFile1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 387);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.browse2Button);
            this.Controls.Add(this.LabelFile2);
            this.Controls.Add(this.file2TextBox);
            this.Controls.Add(this.browse1Button);
            this.Controls.Add(this.LabelFile1);
            this.Controls.Add(this.file1TextBox);
            this.Name = "Form1";
            this.Text = "Oef 18.4 Vergelijk bestanden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label resultLabel;
        internal System.Windows.Forms.Button compareButton;
        internal System.Windows.Forms.Button browse2Button;
        internal System.Windows.Forms.Label LabelFile2;
        internal System.Windows.Forms.TextBox file2TextBox;
        internal System.Windows.Forms.Button browse1Button;
        internal System.Windows.Forms.Label LabelFile1;
        internal System.Windows.Forms.TextBox file1TextBox;
    }
}

