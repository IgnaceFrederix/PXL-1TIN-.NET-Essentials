﻿namespace Oef17_9_BankRekeningMetErrorProvider
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
            this.components = new System.ComponentModel.Container();
            this.saldoButton = new System.Windows.Forms.Button();
            this.saldoLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.stortingOpnameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saldoButton
            // 
            this.saldoButton.Location = new System.Drawing.Point(156, 52);
            this.saldoButton.Name = "saldoButton";
            this.saldoButton.Size = new System.Drawing.Size(100, 23);
            this.saldoButton.TabIndex = 9;
            this.saldoButton.Text = "Saldo";
            this.saldoButton.Click += new System.EventHandler(this.saldoButton_Click);
            // 
            // saldoLabel
            // 
            this.saldoLabel.Location = new System.Drawing.Point(156, 103);
            this.saldoLabel.Name = "saldoLabel";
            this.saldoLabel.Size = new System.Drawing.Size(100, 23);
            this.saldoLabel.TabIndex = 8;
            this.saldoLabel.Text = "Label3";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(28, 103);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Saldo:";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(28, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(120, 23);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Storting(+)/Opname(-):";
            // 
            // ErrorProvider1
            // 
            this.ErrorProvider1.ContainerControl = this;
            // 
            // stortingOpnameTextBox
            // 
            this.stortingOpnameTextBox.Location = new System.Drawing.Point(156, 15);
            this.stortingOpnameTextBox.Name = "stortingOpnameTextBox";
            this.stortingOpnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.stortingOpnameTextBox.TabIndex = 5;
            this.stortingOpnameTextBox.Text = "TextBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.saldoButton);
            this.Controls.Add(this.saldoLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.stortingOpnameTextBox);
            this.Name = "Form1";
            this.Text = "Oef 17.9 Bankrekening";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button saldoButton;
        internal System.Windows.Forms.Label saldoLabel;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ErrorProvider ErrorProvider1;
        internal System.Windows.Forms.TextBox stortingOpnameTextBox;
    }
}

