namespace Oef17_7_Bankrekening
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
            this.saldoButton = new System.Windows.Forms.Button();
            this.saldoLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.bedragTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saldoButton
            // 
            this.saldoButton.Location = new System.Drawing.Point(78, 47);
            this.saldoButton.Name = "saldoButton";
            this.saldoButton.Size = new System.Drawing.Size(75, 23);
            this.saldoButton.TabIndex = 9;
            this.saldoButton.Text = "Saldo";
            this.saldoButton.Click += new System.EventHandler(this.saldoButton_Click);
            // 
            // saldoLabel
            // 
            this.saldoLabel.Location = new System.Drawing.Point(140, 97);
            this.saldoLabel.Name = "saldoLabel";
            this.saldoLabel.Size = new System.Drawing.Size(100, 23);
            this.saldoLabel.TabIndex = 8;
            this.saldoLabel.Text = "Label3";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(12, 97);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Saldo";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 23);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Storting(+)/Opname(-):";
            // 
            // bedragTextBox
            // 
            this.bedragTextBox.Location = new System.Drawing.Point(140, 9);
            this.bedragTextBox.Name = "bedragTextBox";
            this.bedragTextBox.Size = new System.Drawing.Size(100, 20);
            this.bedragTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 128);
            this.Controls.Add(this.saldoButton);
            this.Controls.Add(this.saldoLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.bedragTextBox);
            this.Name = "Form1";
            this.Text = "Oef 17.7 Bankrekening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button saldoButton;
        internal System.Windows.Forms.Label saldoLabel;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox bedragTextBox;
    }
}

