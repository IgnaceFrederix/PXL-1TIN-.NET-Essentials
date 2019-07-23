namespace Oef15_6_KunstmatigLeven
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
            this.lifeTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.eersteTextBox = new System.Windows.Forms.TextBox();
            this.aantalTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.volgendeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lifeTextBox
            // 
            this.lifeTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifeTextBox.Location = new System.Drawing.Point(17, 87);
            this.lifeTextBox.Multiline = true;
            this.lifeTextBox.Name = "lifeTextBox";
            this.lifeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.lifeTextBox.Size = new System.Drawing.Size(463, 294);
            this.lifeTextBox.TabIndex = 11;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(14, 52);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Index eerste cel:";
            // 
            // eersteTextBox
            // 
            this.eersteTextBox.Location = new System.Drawing.Point(108, 49);
            this.eersteTextBox.Name = "eersteTextBox";
            this.eersteTextBox.Size = new System.Drawing.Size(100, 20);
            this.eersteTextBox.TabIndex = 9;
            // 
            // aantalTextBox
            // 
            this.aantalTextBox.Location = new System.Drawing.Point(108, 12);
            this.aantalTextBox.Name = "aantalTextBox";
            this.aantalTextBox.Size = new System.Drawing.Size(100, 20);
            this.aantalTextBox.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(91, 13);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Aantal kolommen:";
            // 
            // volgendeButton
            // 
            this.volgendeButton.Location = new System.Drawing.Point(405, 15);
            this.volgendeButton.Name = "volgendeButton";
            this.volgendeButton.Size = new System.Drawing.Size(75, 23);
            this.volgendeButton.TabIndex = 6;
            this.volgendeButton.Text = "Volgende";
            this.volgendeButton.UseVisualStyleBackColor = true;
            this.volgendeButton.Click += new System.EventHandler(this.volgendeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 394);
            this.Controls.Add(this.lifeTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.eersteTextBox);
            this.Controls.Add(this.aantalTextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.volgendeButton);
            this.Name = "Form1";
            this.Text = "Oef 15.6 Kunstmatig leven";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox lifeTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox eersteTextBox;
        internal System.Windows.Forms.TextBox aantalTextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button volgendeButton;
    }
}

