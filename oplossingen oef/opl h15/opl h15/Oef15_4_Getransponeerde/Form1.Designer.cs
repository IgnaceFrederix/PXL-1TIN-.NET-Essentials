namespace Oef15_4_Getransponeerde
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
            this.transposeTextox = new System.Windows.Forms.TextBox();
            this.transponeerButton = new System.Windows.Forms.Button();
            this.matrixTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // transposeTextox
            // 
            this.transposeTextox.Location = new System.Drawing.Point(22, 172);
            this.transposeTextox.Multiline = true;
            this.transposeTextox.Name = "transposeTextox";
            this.transposeTextox.Size = new System.Drawing.Size(208, 88);
            this.transposeTextox.TabIndex = 5;
            // 
            // transponeerButton
            // 
            this.transponeerButton.Location = new System.Drawing.Point(82, 121);
            this.transponeerButton.Name = "transponeerButton";
            this.transponeerButton.Size = new System.Drawing.Size(80, 23);
            this.transponeerButton.TabIndex = 4;
            this.transponeerButton.Text = "Transponeer";
            this.transponeerButton.Click += new System.EventHandler(this.transponeerButton_Click);
            // 
            // matrixTextBox
            // 
            this.matrixTextBox.Location = new System.Drawing.Point(22, 12);
            this.matrixTextBox.Multiline = true;
            this.matrixTextBox.Name = "matrixTextBox";
            this.matrixTextBox.Size = new System.Drawing.Size(208, 88);
            this.matrixTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 278);
            this.Controls.Add(this.transposeTextox);
            this.Controls.Add(this.transponeerButton);
            this.Controls.Add(this.matrixTextBox);
            this.Name = "Form1";
            this.Text = "Oef 15.4 Getransponeerde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox transposeTextox;
        internal System.Windows.Forms.Button transponeerButton;
        internal System.Windows.Forms.TextBox matrixTextBox;
    }
}

