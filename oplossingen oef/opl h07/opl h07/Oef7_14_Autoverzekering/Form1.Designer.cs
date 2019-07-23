namespace Oef7_14_Autoverzekering
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
            this.label1 = new System.Windows.Forms.Label();
            this.vrouwRadioButton = new System.Windows.Forms.RadioButton();
            this.leeftijd60RadioButton = new System.Windows.Forms.RadioButton();
            this.leeftijd4560RadioButton = new System.Windows.Forms.RadioButton();
            this.leeftijd3045RadioButton = new System.Windows.Forms.RadioButton();
            this.leeftijd1830RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naam";
            // 
            // vrouwRadioButton
            // 
            this.vrouwRadioButton.AutoSize = true;
            this.vrouwRadioButton.Location = new System.Drawing.Point(135, 19);
            this.vrouwRadioButton.Name = "vrouwRadioButton";
            this.vrouwRadioButton.Size = new System.Drawing.Size(55, 17);
            this.vrouwRadioButton.TabIndex = 1;
            this.vrouwRadioButton.TabStop = true;
            this.vrouwRadioButton.Text = "Vrouw";
            this.vrouwRadioButton.UseVisualStyleBackColor = true;
            // 
            // leeftijd60RadioButton
            // 
            this.leeftijd60RadioButton.AutoSize = true;
            this.leeftijd60RadioButton.Location = new System.Drawing.Point(81, 68);
            this.leeftijd60RadioButton.Name = "leeftijd60RadioButton";
            this.leeftijd60RadioButton.Size = new System.Drawing.Size(88, 17);
            this.leeftijd60RadioButton.TabIndex = 3;
            this.leeftijd60RadioButton.Text = "ouder dan 60";
            this.leeftijd60RadioButton.UseVisualStyleBackColor = true;
            // 
            // leeftijd4560RadioButton
            // 
            this.leeftijd4560RadioButton.AutoSize = true;
            this.leeftijd4560RadioButton.Location = new System.Drawing.Point(81, 51);
            this.leeftijd4560RadioButton.Name = "leeftijd4560RadioButton";
            this.leeftijd4560RadioButton.Size = new System.Drawing.Size(101, 17);
            this.leeftijd4560RadioButton.TabIndex = 2;
            this.leeftijd4560RadioButton.Text = "tussen 45 en 60";
            this.leeftijd4560RadioButton.UseVisualStyleBackColor = true;
            // 
            // leeftijd3045RadioButton
            // 
            this.leeftijd3045RadioButton.AutoSize = true;
            this.leeftijd3045RadioButton.Location = new System.Drawing.Point(81, 33);
            this.leeftijd3045RadioButton.Name = "leeftijd3045RadioButton";
            this.leeftijd3045RadioButton.Size = new System.Drawing.Size(101, 17);
            this.leeftijd3045RadioButton.TabIndex = 1;
            this.leeftijd3045RadioButton.Text = "tussen 30 en 45";
            this.leeftijd3045RadioButton.UseVisualStyleBackColor = true;
            // 
            // leeftijd1830RadioButton
            // 
            this.leeftijd1830RadioButton.AutoSize = true;
            this.leeftijd1830RadioButton.Checked = true;
            this.leeftijd1830RadioButton.Location = new System.Drawing.Point(81, 16);
            this.leeftijd1830RadioButton.Name = "leeftijd1830RadioButton";
            this.leeftijd1830RadioButton.Size = new System.Drawing.Size(101, 17);
            this.leeftijd1830RadioButton.TabIndex = 0;
            this.leeftijd1830RadioButton.TabStop = true;
            this.leeftijd1830RadioButton.Text = "tussen 18 en 30";
            this.leeftijd1830RadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.leeftijd60RadioButton);
            this.groupBox2.Controls.Add(this.leeftijd4560RadioButton);
            this.groupBox2.Controls.Add(this.leeftijd3045RadioButton);
            this.groupBox2.Controls.Add(this.leeftijd1830RadioButton);
            this.groupBox2.Location = new System.Drawing.Point(23, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 95);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leeftijd";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(104, 269);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 13;
            this.Button1.Text = "Bereken";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vrouwRadioButton);
            this.groupBox1.Controls.Add(this.manRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 47);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geslacht";
            // 
            // manRadioButton
            // 
            this.manRadioButton.AutoSize = true;
            this.manRadioButton.Checked = true;
            this.manRadioButton.Location = new System.Drawing.Point(83, 19);
            this.manRadioButton.Name = "manRadioButton";
            this.manRadioButton.Size = new System.Drawing.Size(46, 17);
            this.manRadioButton.TabIndex = 0;
            this.manRadioButton.TabStop = true;
            this.manRadioButton.Text = "Man";
            this.manRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Voornaam";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.RadioButton vrouwRadioButton;
        internal System.Windows.Forms.RadioButton leeftijd60RadioButton;
        internal System.Windows.Forms.RadioButton leeftijd4560RadioButton;
        internal System.Windows.Forms.RadioButton leeftijd3045RadioButton;
        internal System.Windows.Forms.RadioButton leeftijd1830RadioButton;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.RadioButton manRadioButton;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox textBox1;
    }
}

