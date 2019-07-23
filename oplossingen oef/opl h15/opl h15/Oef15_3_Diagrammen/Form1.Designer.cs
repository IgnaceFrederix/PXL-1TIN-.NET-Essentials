namespace Oef15_3_Diagrammen
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
            this.cirkelButton = new System.Windows.Forms.Button();
            this.staafButton = new System.Windows.Forms.Button();
            this.rijTextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.chartPicturePox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartPicturePox)).BeginInit();
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
            // cirkelButton
            // 
            this.cirkelButton.Location = new System.Drawing.Point(296, 220);
            this.cirkelButton.Name = "cirkelButton";
            this.cirkelButton.Size = new System.Drawing.Size(75, 23);
            this.cirkelButton.TabIndex = 15;
            this.cirkelButton.Text = "Cirkel";
            this.cirkelButton.UseVisualStyleBackColor = true;
            this.cirkelButton.Click += new System.EventHandler(this.cirkelButton_Click);
            // 
            // staafButton
            // 
            this.staafButton.Location = new System.Drawing.Point(215, 220);
            this.staafButton.Name = "staafButton";
            this.staafButton.Size = new System.Drawing.Size(75, 23);
            this.staafButton.TabIndex = 16;
            this.staafButton.Text = "Staaf";
            this.staafButton.UseVisualStyleBackColor = true;
            this.staafButton.Click += new System.EventHandler(this.staafButton_Click);
            // 
            // rijTextBox
            // 
            this.rijTextBox.Location = new System.Drawing.Point(245, 183);
            this.rijTextBox.Name = "rijTextBox";
            this.rijTextBox.Size = new System.Drawing.Size(54, 20);
            this.rijTextBox.TabIndex = 14;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(222, 186);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(17, 13);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "rij:";
            // 
            // chartPicturePox
            // 
            this.chartPicturePox.BackColor = System.Drawing.Color.White;
            this.chartPicturePox.Location = new System.Drawing.Point(13, 183);
            this.chartPicturePox.Name = "chartPicturePox";
            this.chartPicturePox.Size = new System.Drawing.Size(200, 200);
            this.chartPicturePox.TabIndex = 12;
            this.chartPicturePox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 404);
            this.Controls.Add(this.cirkelButton);
            this.Controls.Add(this.staafButton);
            this.Controls.Add(this.rijTextBox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.chartPicturePox);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeButton);
            this.Name = "Form1";
            this.Text = "Oef 15.3 Diagrammen";
            ((System.ComponentModel.ISupportInitialize)(this.chartPicturePox)).EndInit();
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
        internal System.Windows.Forms.Button cirkelButton;
        internal System.Windows.Forms.Button staafButton;
        internal System.Windows.Forms.TextBox rijTextBox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.PictureBox chartPicturePox;
    }
}

