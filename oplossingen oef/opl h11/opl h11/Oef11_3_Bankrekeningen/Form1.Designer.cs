namespace Oef11_3_Bankrekeningen
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
            this.renteGoldenLabel = new System.Windows.Forms.Label();
            this.renteGewoonLabel = new System.Windows.Forms.Label();
            this.renteButton = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.stortingOpnameTextBox = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.saldoGoldenLabel = new System.Windows.Forms.Label();
            this.saldoButton = new System.Windows.Forms.Button();
            this.saldoGewoonLabel = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // renteGoldenLabel
            // 
            this.renteGoldenLabel.Location = new System.Drawing.Point(434, 312);
            this.renteGoldenLabel.Name = "renteGoldenLabel";
            this.renteGoldenLabel.Size = new System.Drawing.Size(100, 23);
            this.renteGoldenLabel.TabIndex = 22;
            this.renteGoldenLabel.Text = "Label3";
            // 
            // renteGewoonLabel
            // 
            this.renteGewoonLabel.Location = new System.Drawing.Point(114, 312);
            this.renteGewoonLabel.Name = "renteGewoonLabel";
            this.renteGewoonLabel.Size = new System.Drawing.Size(100, 23);
            this.renteGewoonLabel.TabIndex = 21;
            this.renteGewoonLabel.Text = "Label3";
            // 
            // renteButton
            // 
            this.renteButton.Location = new System.Drawing.Point(18, 264);
            this.renteButton.Name = "renteButton";
            this.renteButton.Size = new System.Drawing.Size(616, 23);
            this.renteButton.TabIndex = 20;
            this.renteButton.Text = "Rente";
            this.renteButton.Click += new System.EventHandler(this.renteButton_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.stortingOpnameTextBox);
            this.GroupBox1.Location = new System.Drawing.Point(18, 8);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(616, 104);
            this.GroupBox1.TabIndex = 19;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Storting(+)/Opname(-):";
            // 
            // stortingOpnameTextBox
            // 
            this.stortingOpnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stortingOpnameTextBox.Location = new System.Drawing.Point(224, 40);
            this.stortingOpnameTextBox.Name = "stortingOpnameTextBox";
            this.stortingOpnameTextBox.Size = new System.Drawing.Size(152, 31);
            this.stortingOpnameTextBox.TabIndex = 0;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(354, 128);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(280, 48);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Golden Rekening";
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(18, 128);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(296, 48);
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Gewone Rekening";
            // 
            // saldoGoldenLabel
            // 
            this.saldoGoldenLabel.Location = new System.Drawing.Point(434, 232);
            this.saldoGoldenLabel.Name = "saldoGoldenLabel";
            this.saldoGoldenLabel.Size = new System.Drawing.Size(100, 23);
            this.saldoGoldenLabel.TabIndex = 16;
            this.saldoGoldenLabel.Text = "Label3";
            // 
            // saldoButton
            // 
            this.saldoButton.Location = new System.Drawing.Point(18, 192);
            this.saldoButton.Name = "saldoButton";
            this.saldoButton.Size = new System.Drawing.Size(616, 23);
            this.saldoButton.TabIndex = 15;
            this.saldoButton.Text = "Saldo";
            this.saldoButton.Click += new System.EventHandler(this.saldoButton_Click);
            // 
            // saldoGewoonLabel
            // 
            this.saldoGewoonLabel.Location = new System.Drawing.Point(114, 232);
            this.saldoGewoonLabel.Name = "saldoGewoonLabel";
            this.saldoGewoonLabel.Size = new System.Drawing.Size(100, 23);
            this.saldoGewoonLabel.TabIndex = 14;
            this.saldoGewoonLabel.Text = "Label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 339);
            this.Controls.Add(this.renteGoldenLabel);
            this.Controls.Add(this.renteGewoonLabel);
            this.Controls.Add(this.renteButton);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.saldoGoldenLabel);
            this.Controls.Add(this.saldoButton);
            this.Controls.Add(this.saldoGewoonLabel);
            this.Name = "Form1";
            this.Text = "Oef 11.3 Bankrekening";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label renteGoldenLabel;
        internal System.Windows.Forms.Label renteGewoonLabel;
        internal System.Windows.Forms.Button renteButton;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox stortingOpnameTextBox;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label saldoGoldenLabel;
        internal System.Windows.Forms.Button saldoButton;
        internal System.Windows.Forms.Label saldoGewoonLabel;
    }
}

