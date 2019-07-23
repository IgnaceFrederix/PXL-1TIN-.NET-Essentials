namespace Oef15_1_Gegevensverwerker
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
            this.changeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.factorButton = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.factorTextBox = new System.Windows.Forms.TextBox();
            this.largestButton = new System.Windows.Forms.Button();
            this.sumLocationTextBox = new System.Windows.Forms.TextBox();
            this.sumDayTextBox = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(12, 18);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 0;
            this.changeButton.Text = "Verander";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Locatie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dag:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Naar:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(156, 21);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(38, 20);
            this.locationTextBox.TabIndex = 2;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(245, 21);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(38, 20);
            this.dayTextBox.TabIndex = 2;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(333, 21);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(38, 20);
            this.valueTextBox.TabIndex = 2;
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(12, 58);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(359, 115);
            this.dataTextBox.TabIndex = 3;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(156, 186);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 13);
            this.totalLabel.TabIndex = 4;
            // 
            // factorButton
            // 
            this.factorButton.Location = new System.Drawing.Point(336, 225);
            this.factorButton.Name = "factorButton";
            this.factorButton.Size = new System.Drawing.Size(75, 23);
            this.factorButton.TabIndex = 22;
            this.factorButton.Text = "Factor";
            this.factorButton.Click += new System.EventHandler(this.factorButton_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(218, 230);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 23);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Factor:";
            // 
            // factorTextBox
            // 
            this.factorTextBox.Location = new System.Drawing.Point(265, 227);
            this.factorTextBox.Name = "factorTextBox";
            this.factorTextBox.Size = new System.Drawing.Size(48, 20);
            this.factorTextBox.TabIndex = 20;
            // 
            // largestButton
            // 
            this.largestButton.Location = new System.Drawing.Point(119, 225);
            this.largestButton.Name = "largestButton";
            this.largestButton.Size = new System.Drawing.Size(75, 23);
            this.largestButton.TabIndex = 19;
            this.largestButton.Text = "Grootste";
            this.largestButton.Click += new System.EventHandler(this.largestButton_Click);
            // 
            // sumLocationTextBox
            // 
            this.sumLocationTextBox.Location = new System.Drawing.Point(377, 58);
            this.sumLocationTextBox.Multiline = true;
            this.sumLocationTextBox.Name = "sumLocationTextBox";
            this.sumLocationTextBox.Size = new System.Drawing.Size(32, 115);
            this.sumLocationTextBox.TabIndex = 18;
            // 
            // sumDayTextBox
            // 
            this.sumDayTextBox.Location = new System.Drawing.Point(12, 186);
            this.sumDayTextBox.Multiline = true;
            this.sumDayTextBox.Name = "sumDayTextBox";
            this.sumDayTextBox.Size = new System.Drawing.Size(359, 20);
            this.sumDayTextBox.TabIndex = 17;
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(12, 225);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 16;
            this.totalButton.Text = "Totalen";
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 272);
            this.Controls.Add(this.factorButton);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.factorTextBox);
            this.Controls.Add(this.largestButton);
            this.Controls.Add(this.sumLocationTextBox);
            this.Controls.Add(this.sumDayTextBox);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeButton);
            this.Name = "Form1";
            this.Text = "Oef 15.1 Gegevensverwerker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Label totalLabel;
        internal System.Windows.Forms.Button factorButton;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox factorTextBox;
        internal System.Windows.Forms.Button largestButton;
        internal System.Windows.Forms.TextBox sumLocationTextBox;
        internal System.Windows.Forms.TextBox sumDayTextBox;
        internal System.Windows.Forms.Button totalButton;
    }
}

