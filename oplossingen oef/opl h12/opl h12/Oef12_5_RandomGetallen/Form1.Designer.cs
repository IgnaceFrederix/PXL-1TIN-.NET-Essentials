namespace Oef12_5_RandomGetallen
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
            this.Label2 = new System.Windows.Forms.Label();
            this.random2Label = new System.Windows.Forms.Label();
            this.random1Label = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.genereerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(186, 75);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(49, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Aantal 2:";
            // 
            // random2Label
            // 
            this.random2Label.AutoSize = true;
            this.random2Label.Location = new System.Drawing.Point(238, 75);
            this.random2Label.Name = "random2Label";
            this.random2Label.Size = new System.Drawing.Size(13, 13);
            this.random2Label.TabIndex = 5;
            this.random2Label.Text = "0";
            // 
            // random1Label
            // 
            this.random1Label.AutoSize = true;
            this.random1Label.Location = new System.Drawing.Point(95, 75);
            this.random1Label.Name = "random1Label";
            this.random1Label.Size = new System.Drawing.Size(13, 13);
            this.random1Label.TabIndex = 6;
            this.random1Label.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(37, 75);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Aantal 1:";
            // 
            // genereerButton
            // 
            this.genereerButton.Location = new System.Drawing.Point(98, 12);
            this.genereerButton.Name = "genereerButton";
            this.genereerButton.Size = new System.Drawing.Size(75, 23);
            this.genereerButton.TabIndex = 2;
            this.genereerButton.Text = "Genereer";
            this.genereerButton.UseVisualStyleBackColor = true;
            this.genereerButton.Click += new System.EventHandler(this.genereerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 110);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.random2Label);
            this.Controls.Add(this.random1Label);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.genereerButton);
            this.Name = "Form1";
            this.Text = "Oef 12.5 Random getallen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label random2Label;
        internal System.Windows.Forms.Label random1Label;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button genereerButton;
    }
}

