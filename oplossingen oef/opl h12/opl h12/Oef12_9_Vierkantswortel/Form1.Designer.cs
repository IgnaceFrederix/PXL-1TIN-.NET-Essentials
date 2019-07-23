namespace Oef12_9_Vierkantswortel
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
            this.benaderingTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.exactTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.getalTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // benaderingTextBox
            // 
            this.benaderingTextBox.Location = new System.Drawing.Point(11, 123);
            this.benaderingTextBox.Multiline = true;
            this.benaderingTextBox.Name = "benaderingTextBox";
            this.benaderingTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.benaderingTextBox.Size = new System.Drawing.Size(265, 129);
            this.benaderingTextBox.TabIndex = 13;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(128, 87);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 92);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(61, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Benadering";
            // 
            // exactTextBox
            // 
            this.exactTextBox.Location = new System.Drawing.Point(128, 49);
            this.exactTextBox.Name = "exactTextBox";
            this.exactTextBox.Size = new System.Drawing.Size(148, 20);
            this.exactTextBox.TabIndex = 10;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(114, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Vierkantswortel (exact)";
            // 
            // getalTextBox
            // 
            this.getalTextBox.Location = new System.Drawing.Point(128, 11);
            this.getalTextBox.Name = "getalTextBox";
            this.getalTextBox.Size = new System.Drawing.Size(148, 20);
            this.getalTextBox.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Geef een getal:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.benaderingTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.exactTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.getalTextBox);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 12.9 Vierkantswortel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox benaderingTextBox;
        internal System.Windows.Forms.Button startButton;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox exactTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox getalTextBox;
        internal System.Windows.Forms.Label Label1;
    }
}

