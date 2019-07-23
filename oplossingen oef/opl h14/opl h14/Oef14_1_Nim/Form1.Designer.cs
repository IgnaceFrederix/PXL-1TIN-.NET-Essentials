namespace Oef14_1_Nim
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
            this.lblComputer = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.stapelComboBox = new System.Windows.Forms.ComboBox();
            this.aantalTextBox = new System.Windows.Forms.TextBox();
            this.verwijderButton = new System.Windows.Forms.Button();
            this.lblStapel3 = new System.Windows.Forms.Label();
            this.lblStapel2 = new System.Windows.Forms.Label();
            this.lblStapel1 = new System.Windows.Forms.Label();
            this.stapel3ProgressBar = new System.Windows.Forms.ProgressBar();
            this.stapel2ProgressBar = new System.Windows.Forms.ProgressBar();
            this.stapel1ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(76, 358);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(0, 13);
            this.lblComputer.TabIndex = 18;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(13, 358);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(52, 13);
            this.resultLabel.TabIndex = 16;
            this.resultLabel.Text = "Computer";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 316);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 13);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Speler";
            // 
            // stapelComboBox
            // 
            this.stapelComboBox.FormattingEnabled = true;
            this.stapelComboBox.Items.AddRange(new object[] {
            "Stapel 1",
            "Stapel 2",
            "Stapel 3"});
            this.stapelComboBox.Location = new System.Drawing.Point(140, 308);
            this.stapelComboBox.Name = "stapelComboBox";
            this.stapelComboBox.Size = new System.Drawing.Size(101, 21);
            this.stapelComboBox.TabIndex = 15;
            // 
            // aantalTextBox
            // 
            this.aantalTextBox.Location = new System.Drawing.Point(79, 309);
            this.aantalTextBox.Name = "aantalTextBox";
            this.aantalTextBox.Size = new System.Drawing.Size(55, 20);
            this.aantalTextBox.TabIndex = 14;
            // 
            // verwijderButton
            // 
            this.verwijderButton.Location = new System.Drawing.Point(247, 306);
            this.verwijderButton.Name = "verwijderButton";
            this.verwijderButton.Size = new System.Drawing.Size(75, 23);
            this.verwijderButton.TabIndex = 13;
            this.verwijderButton.Text = "Verwijder";
            this.verwijderButton.UseVisualStyleBackColor = true;
            this.verwijderButton.Click += new System.EventHandler(this.verwijderButton_Click);
            // 
            // lblStapel3
            // 
            this.lblStapel3.Location = new System.Drawing.Point(2, 244);
            this.lblStapel3.Name = "lblStapel3";
            this.lblStapel3.Size = new System.Drawing.Size(59, 23);
            this.lblStapel3.TabIndex = 10;
            this.lblStapel3.Text = "Label1";
            this.lblStapel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStapel2
            // 
            this.lblStapel2.Location = new System.Drawing.Point(2, 155);
            this.lblStapel2.Name = "lblStapel2";
            this.lblStapel2.Size = new System.Drawing.Size(59, 23);
            this.lblStapel2.TabIndex = 11;
            this.lblStapel2.Text = "Label1";
            this.lblStapel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStapel1
            // 
            this.lblStapel1.Location = new System.Drawing.Point(2, 68);
            this.lblStapel1.Name = "lblStapel1";
            this.lblStapel1.Size = new System.Drawing.Size(59, 23);
            this.lblStapel1.TabIndex = 12;
            this.lblStapel1.Text = "Label1";
            this.lblStapel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stapel3ProgressBar
            // 
            this.stapel3ProgressBar.Location = new System.Drawing.Point(79, 209);
            this.stapel3ProgressBar.Maximum = 20;
            this.stapel3ProgressBar.Name = "stapel3ProgressBar";
            this.stapel3ProgressBar.Size = new System.Drawing.Size(367, 58);
            this.stapel3ProgressBar.Step = 1;
            this.stapel3ProgressBar.TabIndex = 7;
            // 
            // stapel2ProgressBar
            // 
            this.stapel2ProgressBar.Location = new System.Drawing.Point(79, 120);
            this.stapel2ProgressBar.Maximum = 20;
            this.stapel2ProgressBar.Name = "stapel2ProgressBar";
            this.stapel2ProgressBar.Size = new System.Drawing.Size(367, 58);
            this.stapel2ProgressBar.Step = 1;
            this.stapel2ProgressBar.TabIndex = 8;
            // 
            // stapel1ProgressBar
            // 
            this.stapel1ProgressBar.Location = new System.Drawing.Point(79, 33);
            this.stapel1ProgressBar.Maximum = 20;
            this.stapel1ProgressBar.Name = "stapel1ProgressBar";
            this.stapel1ProgressBar.Size = new System.Drawing.Size(367, 58);
            this.stapel1ProgressBar.Step = 1;
            this.stapel1ProgressBar.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 411);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.stapelComboBox);
            this.Controls.Add(this.aantalTextBox);
            this.Controls.Add(this.verwijderButton);
            this.Controls.Add(this.lblStapel3);
            this.Controls.Add(this.lblStapel2);
            this.Controls.Add(this.lblStapel1);
            this.Controls.Add(this.stapel3ProgressBar);
            this.Controls.Add(this.stapel2ProgressBar);
            this.Controls.Add(this.stapel1ProgressBar);
            this.Name = "Form1";
            this.Text = "Oef 14.1 Nim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblComputer;
        internal System.Windows.Forms.Label resultLabel;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox stapelComboBox;
        internal System.Windows.Forms.TextBox aantalTextBox;
        internal System.Windows.Forms.Button verwijderButton;
        internal System.Windows.Forms.Label lblStapel3;
        internal System.Windows.Forms.Label lblStapel2;
        internal System.Windows.Forms.Label lblStapel1;
        internal System.Windows.Forms.ProgressBar stapel3ProgressBar;
        internal System.Windows.Forms.ProgressBar stapel2ProgressBar;
        internal System.Windows.Forms.ProgressBar stapel1ProgressBar;
    }
}

