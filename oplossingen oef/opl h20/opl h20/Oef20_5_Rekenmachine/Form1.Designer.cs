namespace Oef20_5_Rekenmachine
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
            this.calcTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(108, 196);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 32);
            this.clearButton.TabIndex = 44;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(12, 196);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(32, 32);
            this.button0.TabIndex = 58;
            this.button0.Text = "0";
            this.button0.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // isButton
            // 
            this.isButton.Location = new System.Drawing.Point(156, 148);
            this.isButton.Name = "isButton";
            this.isButton.Size = new System.Drawing.Size(32, 32);
            this.isButton.TabIndex = 57;
            this.isButton.Text = "=";
            this.isButton.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(108, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(32, 32);
            this.button9.TabIndex = 56;
            this.button9.Text = "9";
            this.button9.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(60, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(32, 32);
            this.button8.TabIndex = 55;
            this.button8.Text = "8";
            this.button8.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 148);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 32);
            this.button7.TabIndex = 54;
            this.button7.Text = "7";
            this.button7.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // minButton
            // 
            this.minButton.Location = new System.Drawing.Point(156, 100);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(32, 32);
            this.minButton.TabIndex = 53;
            this.minButton.Text = "-";
            this.minButton.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(108, 100);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 32);
            this.button6.TabIndex = 52;
            this.button6.Text = "6";
            this.button6.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(60, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 32);
            this.button5.TabIndex = 51;
            this.button5.Text = "5";
            this.button5.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 32);
            this.button4.TabIndex = 50;
            this.button4.Text = "4";
            this.button4.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(156, 52);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(32, 32);
            this.plusButton.TabIndex = 49;
            this.plusButton.Text = "+";
            this.plusButton.Click += new System.EventHandler(this.ButtonOperator_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 32);
            this.button3.TabIndex = 48;
            this.button3.Text = "3";
            this.button3.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 47;
            this.button2.Text = "2";
            this.button2.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 46;
            this.button1.Text = "1";
            this.button1.Click += new System.EventHandler(this.ButtonDigit_Click);
            // 
            // calcTextBox
            // 
            this.calcTextBox.Location = new System.Drawing.Point(12, 12);
            this.calcTextBox.Name = "calcTextBox";
            this.calcTextBox.Size = new System.Drawing.Size(176, 20);
            this.calcTextBox.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 239);
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
            this.Controls.Add(this.calcTextBox);
            this.Name = "Form1";
            this.Text = "Oef 20.5 Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        internal System.Windows.Forms.TextBox calcTextBox;
    }
}

