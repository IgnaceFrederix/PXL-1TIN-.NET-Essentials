namespace Oef14_9_Statistieken
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
            this.chartPictureBox = new System.Windows.Forms.PictureBox();
            this.gemiddeldeLabel = new System.Windows.Forms.Label();
            this.somLabel = new System.Windows.Forms.Label();
            this.kleinsteLabel = new System.Windows.Forms.Label();
            this.grootsteLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPictureBox
            // 
            this.chartPictureBox.BackColor = System.Drawing.Color.White;
            this.chartPictureBox.Location = new System.Drawing.Point(221, 12);
            this.chartPictureBox.Name = "chartPictureBox";
            this.chartPictureBox.Size = new System.Drawing.Size(340, 233);
            this.chartPictureBox.TabIndex = 8;
            this.chartPictureBox.TabStop = false;
            // 
            // gemiddeldeLabel
            // 
            this.gemiddeldeLabel.AutoSize = true;
            this.gemiddeldeLabel.Location = new System.Drawing.Point(30, 168);
            this.gemiddeldeLabel.Name = "gemiddeldeLabel";
            this.gemiddeldeLabel.Size = new System.Drawing.Size(66, 13);
            this.gemiddeldeLabel.TabIndex = 6;
            this.gemiddeldeLabel.Text = "Gemiddelde:";
            // 
            // somLabel
            // 
            this.somLabel.AutoSize = true;
            this.somLabel.Location = new System.Drawing.Point(30, 132);
            this.somLabel.Name = "somLabel";
            this.somLabel.Size = new System.Drawing.Size(31, 13);
            this.somLabel.TabIndex = 7;
            this.somLabel.Text = "Som:";
            // 
            // kleinsteLabel
            // 
            this.kleinsteLabel.AutoSize = true;
            this.kleinsteLabel.Location = new System.Drawing.Point(30, 96);
            this.kleinsteLabel.Name = "kleinsteLabel";
            this.kleinsteLabel.Size = new System.Drawing.Size(47, 13);
            this.kleinsteLabel.TabIndex = 4;
            this.kleinsteLabel.Text = "Kleinste:";
            // 
            // grootsteLabel
            // 
            this.grootsteLabel.AutoSize = true;
            this.grootsteLabel.Location = new System.Drawing.Point(30, 65);
            this.grootsteLabel.Name = "grootsteLabel";
            this.grootsteLabel.Size = new System.Drawing.Size(53, 13);
            this.grootsteLabel.TabIndex = 5;
            this.grootsteLabel.Text = "Grootste: ";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(33, 12);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Genereer";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 289);
            this.Controls.Add(this.chartPictureBox);
            this.Controls.Add(this.gemiddeldeLabel);
            this.Controls.Add(this.somLabel);
            this.Controls.Add(this.kleinsteLabel);
            this.Controls.Add(this.grootsteLabel);
            this.Controls.Add(this.generateButton);
            this.Name = "Form1";
            this.Text = "Oef 14.9 Statistieken";
            ((System.ComponentModel.ISupportInitialize)(this.chartPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox chartPictureBox;
        internal System.Windows.Forms.Label gemiddeldeLabel;
        internal System.Windows.Forms.Label somLabel;
        internal System.Windows.Forms.Label kleinsteLabel;
        internal System.Windows.Forms.Label grootsteLabel;
        internal System.Windows.Forms.Button generateButton;
    }
}

