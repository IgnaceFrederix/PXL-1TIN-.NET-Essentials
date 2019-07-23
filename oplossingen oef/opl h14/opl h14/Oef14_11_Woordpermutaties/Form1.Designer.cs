namespace Oef14_11_Woordpermutaties
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
            this.permutatiesTextBox = new System.Windows.Forms.TextBox();
            this.permuteerButton = new System.Windows.Forms.Button();
            this.woord4TextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.woord2TextBox = new System.Windows.Forms.TextBox();
            this.woord3TextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.woord1TextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // permutatiesTextBox
            // 
            this.permutatiesTextBox.Location = new System.Drawing.Point(10, 125);
            this.permutatiesTextBox.Multiline = true;
            this.permutatiesTextBox.Name = "permutatiesTextBox";
            this.permutatiesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.permutatiesTextBox.Size = new System.Drawing.Size(336, 131);
            this.permutatiesTextBox.TabIndex = 13;
            // 
            // permuteerButton
            // 
            this.permuteerButton.Location = new System.Drawing.Point(10, 82);
            this.permuteerButton.Name = "permuteerButton";
            this.permuteerButton.Size = new System.Drawing.Size(75, 23);
            this.permuteerButton.TabIndex = 14;
            this.permuteerButton.Text = "Permuteer";
            this.permuteerButton.UseVisualStyleBackColor = true;
            this.permuteerButton.Click += new System.EventHandler(this.permuteerButton_Click);
            // 
            // woord4TextBox
            // 
            this.woord4TextBox.Location = new System.Drawing.Point(246, 38);
            this.woord4TextBox.Name = "woord4TextBox";
            this.woord4TextBox.Size = new System.Drawing.Size(100, 20);
            this.woord4TextBox.TabIndex = 12;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(201, 41);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 13);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Woord 4";
            // 
            // woord2TextBox
            // 
            this.woord2TextBox.Location = new System.Drawing.Point(246, 12);
            this.woord2TextBox.Name = "woord2TextBox";
            this.woord2TextBox.Size = new System.Drawing.Size(100, 20);
            this.woord2TextBox.TabIndex = 10;
            // 
            // woord3TextBox
            // 
            this.woord3TextBox.Location = new System.Drawing.Point(52, 38);
            this.woord3TextBox.Name = "woord3TextBox";
            this.woord3TextBox.Size = new System.Drawing.Size(100, 20);
            this.woord3TextBox.TabIndex = 11;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(201, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 13);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Woord 2";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(7, 41);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Woord 3";
            // 
            // woord1TextBox
            // 
            this.woord1TextBox.Location = new System.Drawing.Point(52, 12);
            this.woord1TextBox.Name = "woord1TextBox";
            this.woord1TextBox.Size = new System.Drawing.Size(100, 20);
            this.woord1TextBox.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 13);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Woord 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 268);
            this.Controls.Add(this.permutatiesTextBox);
            this.Controls.Add(this.permuteerButton);
            this.Controls.Add(this.woord4TextBox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.woord2TextBox);
            this.Controls.Add(this.woord3TextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.woord1TextBox);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 14.11 Woordpermutaties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox permutatiesTextBox;
        internal System.Windows.Forms.Button permuteerButton;
        internal System.Windows.Forms.TextBox woord4TextBox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox woord2TextBox;
        internal System.Windows.Forms.TextBox woord3TextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox woord1TextBox;
        internal System.Windows.Forms.Label Label1;
    }
}

