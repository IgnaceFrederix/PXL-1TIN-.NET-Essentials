namespace Oef14_4_Neerslag
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
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.rainfallTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(128, 12);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(27, 20);
            this.valueTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "value:";
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(55, 12);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(27, 20);
            this.indexTextBox.TabIndex = 11;
            this.indexTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "index:";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(161, 10);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 7;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // rainfallTextBox
            // 
            this.rainfallTextBox.Location = new System.Drawing.Point(55, 49);
            this.rainfallTextBox.Multiline = true;
            this.rainfallTextBox.Name = "rainfallTextBox";
            this.rainfallTextBox.Size = new System.Drawing.Size(146, 147);
            this.rainfallTextBox.TabIndex = 5;
            // 
            // minLabel
            // 
            this.minLabel.Location = new System.Drawing.Point(58, 312);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(168, 32);
            this.minLabel.TabIndex = 14;
            // 
            // maxLabel
            // 
            this.maxLabel.Location = new System.Drawing.Point(58, 280);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(168, 32);
            this.maxLabel.TabIndex = 13;
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(58, 248);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(168, 32);
            this.labelTotal.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 385);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.indexTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.rainfallTextBox);
            this.Name = "Form1";
            this.Text = "Oef 14.4 Neerslag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox indexTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox rainfallTextBox;
        internal System.Windows.Forms.Label minLabel;
        internal System.Windows.Forms.Label maxLabel;
        internal System.Windows.Forms.Label labelTotal;
    }
}

