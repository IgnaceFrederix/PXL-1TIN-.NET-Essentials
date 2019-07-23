namespace Oef12_10_Rekenmachine
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
            this.kommaButton = new System.Windows.Forms.Button();
            this.gedeeldButton = new System.Windows.Forms.Button();
            this.maalButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.lnButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.isButton = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kommaButton
            // 
            this.kommaButton.Location = new System.Drawing.Point(76, 264);
            this.kommaButton.Name = "kommaButton";
            this.kommaButton.Size = new System.Drawing.Size(32, 32);
            this.kommaButton.TabIndex = 57;
            this.kommaButton.Text = ",";
            this.kommaButton.Click += new System.EventHandler(this.Nummer_Click);
            // 
            // gedeeldButton
            // 
            this.gedeeldButton.ForeColor = System.Drawing.Color.Red;
            this.gedeeldButton.Location = new System.Drawing.Point(172, 264);
            this.gedeeldButton.Name = "gedeeldButton";
            this.gedeeldButton.Size = new System.Drawing.Size(32, 32);
            this.gedeeldButton.TabIndex = 56;
            this.gedeeldButton.Text = "/";
            this.gedeeldButton.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // maalButton
            // 
            this.maalButton.ForeColor = System.Drawing.Color.Red;
            this.maalButton.Location = new System.Drawing.Point(172, 214);
            this.maalButton.Name = "maalButton";
            this.maalButton.Size = new System.Drawing.Size(32, 32);
            this.maalButton.TabIndex = 55;
            this.maalButton.Text = "*";
            this.maalButton.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.ForeColor = System.Drawing.Color.Magenta;
            this.sqrtButton.Location = new System.Drawing.Point(220, 264);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(37, 32);
            this.sqrtButton.TabIndex = 54;
            this.sqrtButton.Text = "sqrt";
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // lnButton
            // 
            this.lnButton.ForeColor = System.Drawing.Color.Magenta;
            this.lnButton.Location = new System.Drawing.Point(220, 214);
            this.lnButton.Name = "lnButton";
            this.lnButton.Size = new System.Drawing.Size(37, 32);
            this.lnButton.TabIndex = 53;
            this.lnButton.Text = "ln";
            this.lnButton.Click += new System.EventHandler(this.lnButton_Click);
            // 
            // cosButton
            // 
            this.cosButton.ForeColor = System.Drawing.Color.Magenta;
            this.cosButton.Location = new System.Drawing.Point(220, 164);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(37, 32);
            this.cosButton.TabIndex = 52;
            this.cosButton.Text = "cos";
            this.cosButton.Click += new System.EventHandler(this.cosButton_Click);
            // 
            // sinButton
            // 
            this.sinButton.ForeColor = System.Drawing.Color.Magenta;
            this.sinButton.Location = new System.Drawing.Point(220, 114);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(37, 32);
            this.sinButton.TabIndex = 51;
            this.sinButton.Text = "sin";
            this.sinButton.Click += new System.EventHandler(this.sinButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.ForeColor = System.Drawing.Color.Red;
            this.clearButton.Location = new System.Drawing.Point(177, 66);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 32);
            this.clearButton.TabIndex = 36;
            this.clearButton.Text = "C";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // button0
            // 
            this.button0.ForeColor = System.Drawing.Color.Blue;
            this.button0.Location = new System.Drawing.Point(28, 264);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(32, 32);
            this.button0.TabIndex = 50;
            this.button0.Text = "0";
            this.button0.Click += new System.EventHandler(this.Nummer_Click);
            // 
            // isButton
            // 
            this.isButton.ForeColor = System.Drawing.Color.Red;
            this.isButton.Location = new System.Drawing.Point(124, 264);
            this.isButton.Name = "isButton";
            this.isButton.Size = new System.Drawing.Size(32, 32);
            this.isButton.TabIndex = 49;
            this.isButton.Text = "=";
            this.isButton.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // button9
            // 
            this.button9.ForeColor = System.Drawing.Color.Blue;
            this.button9.Location = new System.Drawing.Point(124, 214);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 32);
            this.button9.TabIndex = 48;
            this.button9.Text = "9";
            this.button9.Click += new System.EventHandler(this.Nummer_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.Color.Blue;
            this.button8.Location = new System.Drawing.Point(76, 214);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 32);
            this.button8.TabIndex = 47;
            this.button8.Text = "8";
            this.button8.Click += new System.EventHandler(this.Nummer_Click);
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Blue;
            this.button7.Location = new System.Drawing.Point(28, 214);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 32);
            this.button7.TabIndex = 46;
            this.button7.Text = "7";
            this.button7.Click += new System.EventHandler(this.Nummer_Click);
            // 
            // minButton
            // 
            this.minButton.ForeColor = System.Drawing.Color.Red;
            this.minButton.Location = new System.Drawing.Point(172, 164);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(32, 32);
            this.minButton.TabIndex = 45;
            this.minButton.Text = "-";
            this.minButton.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // button6
            // 
            this.button6.ForeColor = System.Drawing.Color.Blue;
            this.button6.Location = new System.Drawing.Point(124, 164);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 32);
            this.button6.TabIndex = 44;
            this.button6.Text = "6";
            this.button6.Click += new System.EventHandler(this.Nummer_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(76, 164);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 32);
            this.button5.TabIndex = 43;
            this.button5.Text = "5";
            this.button5.Click += new System.EventHandler(this.Nummer_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(28, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 42;
            this.button4.Text = "4";
            this.button4.Click += new System.EventHandler(this.Nummer_Click);
            // 
            // plusButton
            // 
            this.plusButton.ForeColor = System.Drawing.Color.Red;
            this.plusButton.Location = new System.Drawing.Point(172, 114);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(32, 32);
            this.plusButton.TabIndex = 41;
            this.plusButton.Text = "+";
            this.plusButton.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(124, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 40;
            this.button3.Text = "3";
            this.button3.Click += new System.EventHandler(this.Nummer_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(76, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 39;
            this.button2.Text = "2";
            this.button2.Click += new System.EventHandler(this.Nummer_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(28, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 38;
            this.button1.Text = "1";
            this.button1.Click += new System.EventHandler(this.Nummer_Click);
            // 
            // displayTextBox
            // 
            this.displayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTextBox.Location = new System.Drawing.Point(28, 26);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(229, 26);
            this.displayTextBox.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 322);
            this.Controls.Add(this.kommaButton);
            this.Controls.Add(this.gedeeldButton);
            this.Controls.Add(this.maalButton);
            this.Controls.Add(this.sqrtButton);
            this.Controls.Add(this.lnButton);
            this.Controls.Add(this.cosButton);
            this.Controls.Add(this.sinButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.isButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayTextBox);
            this.Name = "Form1";
            this.Text = "Oef 12.10 Rekenmachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button kommaButton;
        internal System.Windows.Forms.Button gedeeldButton;
        internal System.Windows.Forms.Button maalButton;
        internal System.Windows.Forms.Button sqrtButton;
        internal System.Windows.Forms.Button lnButton;
        internal System.Windows.Forms.Button cosButton;
        internal System.Windows.Forms.Button sinButton;
        internal System.Windows.Forms.Button clearButton;
        internal System.Windows.Forms.Button button0;
        internal System.Windows.Forms.Button isButton;
        internal System.Windows.Forms.Button button9;
        internal System.Windows.Forms.Button button8;
        internal System.Windows.Forms.Button button7;
        internal System.Windows.Forms.Button minButton;
        internal System.Windows.Forms.Button button6;
        internal System.Windows.Forms.Button button5;
        internal System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Button plusButton;
        internal System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox displayTextBox;
    }
}

