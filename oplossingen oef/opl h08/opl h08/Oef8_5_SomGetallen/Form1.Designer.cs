namespace Oef8_5_SomGetallen
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
            this.Label3 = new System.Windows.Forms.Label();
            this.controleButton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.somButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(86, 207);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 23);
            this.Label3.TabIndex = 9;
            // 
            // controleButton
            // 
            this.controleButton.Location = new System.Drawing.Point(86, 165);
            this.controleButton.Name = "controleButton";
            this.controleButton.Size = new System.Drawing.Size(88, 23);
            this.controleButton.TabIndex = 8;
            this.controleButton.Text = "Controle";
            this.controleButton.Click += new System.EventHandler(this.controleButton_Click);
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(86, 122);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 24);
            this.Label2.TabIndex = 7;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(70, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(144, 32);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Getal 0 t.e.m. 39";
            // 
            // somButton
            // 
            this.somButton.Location = new System.Drawing.Point(86, 80);
            this.somButton.Name = "somButton";
            this.somButton.Size = new System.Drawing.Size(88, 23);
            this.somButton.TabIndex = 5;
            this.somButton.Text = "Sommeer";
            this.somButton.Click += new System.EventHandler(this.somButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.controleButton);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.somButton);
            this.Name = "Form1";
            this.Text = "Oef 8.5 Som gehele getallen";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button controleButton;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button somButton;
    }
}

