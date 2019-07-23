namespace Oef15_2_StatistischeGegevens
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
            this.devLocTextBox = new System.Windows.Forms.TextBox();
            this.avgLocationTextBox = new System.Windows.Forms.TextBox();
            this.devDayTextBox = new System.Windows.Forms.TextBox();
            this.avgDayTextBox = new System.Windows.Forms.TextBox();
            this.avgButton = new System.Windows.Forms.Button();
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
            // devLocTextBox
            // 
            this.devLocTextBox.Location = new System.Drawing.Point(415, 58);
            this.devLocTextBox.Multiline = true;
            this.devLocTextBox.Name = "devLocTextBox";
            this.devLocTextBox.Size = new System.Drawing.Size(57, 115);
            this.devLocTextBox.TabIndex = 15;
            // 
            // avgLocationTextBox
            // 
            this.avgLocationTextBox.Location = new System.Drawing.Point(377, 58);
            this.avgLocationTextBox.Multiline = true;
            this.avgLocationTextBox.Name = "avgLocationTextBox";
            this.avgLocationTextBox.Size = new System.Drawing.Size(32, 115);
            this.avgLocationTextBox.TabIndex = 16;
            // 
            // devDayTextBox
            // 
            this.devDayTextBox.Location = new System.Drawing.Point(12, 217);
            this.devDayTextBox.Multiline = true;
            this.devDayTextBox.Name = "devDayTextBox";
            this.devDayTextBox.Size = new System.Drawing.Size(359, 20);
            this.devDayTextBox.TabIndex = 14;
            // 
            // avgDayTextBox
            // 
            this.avgDayTextBox.Location = new System.Drawing.Point(12, 191);
            this.avgDayTextBox.Multiline = true;
            this.avgDayTextBox.Name = "avgDayTextBox";
            this.avgDayTextBox.Size = new System.Drawing.Size(359, 20);
            this.avgDayTextBox.TabIndex = 13;
            // 
            // avgButton
            // 
            this.avgButton.Location = new System.Drawing.Point(12, 257);
            this.avgButton.Name = "avgButton";
            this.avgButton.Size = new System.Drawing.Size(75, 23);
            this.avgButton.TabIndex = 12;
            this.avgButton.Text = "Gemiddelden";
            this.avgButton.Click += new System.EventHandler(this.avgButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 289);
            this.Controls.Add(this.devLocTextBox);
            this.Controls.Add(this.avgLocationTextBox);
            this.Controls.Add(this.devDayTextBox);
            this.Controls.Add(this.avgDayTextBox);
            this.Controls.Add(this.avgButton);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeButton);
            this.Name = "Form1";
            this.Text = "Oef 15.2 Statistische gegevens";
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
        internal System.Windows.Forms.TextBox devLocTextBox;
        internal System.Windows.Forms.TextBox avgLocationTextBox;
        internal System.Windows.Forms.TextBox devDayTextBox;
        internal System.Windows.Forms.TextBox avgDayTextBox;
        internal System.Windows.Forms.Button avgButton;
    }
}

