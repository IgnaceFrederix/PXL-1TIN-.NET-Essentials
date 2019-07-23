namespace Oef17_4_Datums
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
            this.checkButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.jaarTextBox = new System.Windows.Forms.TextBox();
            this.maandTextBox = new System.Windows.Forms.TextBox();
            this.dagTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(163, 77);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 10;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(171, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(12, 13);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "/";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(117, 25);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(12, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "/";
            // 
            // jaarTextBox
            // 
            this.jaarTextBox.Location = new System.Drawing.Point(189, 22);
            this.jaarTextBox.Name = "jaarTextBox";
            this.jaarTextBox.Size = new System.Drawing.Size(49, 20);
            this.jaarTextBox.TabIndex = 7;
            // 
            // maandTextBox
            // 
            this.maandTextBox.Location = new System.Drawing.Point(135, 22);
            this.maandTextBox.Name = "maandTextBox";
            this.maandTextBox.Size = new System.Drawing.Size(30, 20);
            this.maandTextBox.TabIndex = 6;
            // 
            // dagTextBox
            // 
            this.dagTextBox.Location = new System.Drawing.Point(81, 22);
            this.dagTextBox.Name = "dagTextBox";
            this.dagTextBox.Size = new System.Drawing.Size(30, 20);
            this.dagTextBox.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(22, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(53, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "dd/mm/jjjj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 114);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.jaarTextBox);
            this.Controls.Add(this.maandTextBox);
            this.Controls.Add(this.dagTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 17.4 Datums";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button checkButton;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox jaarTextBox;
        internal System.Windows.Forms.TextBox maandTextBox;
        internal System.Windows.Forms.TextBox dagTextBox;
        internal System.Windows.Forms.Label Label1;
    }
}

