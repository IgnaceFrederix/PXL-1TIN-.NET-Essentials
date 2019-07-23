namespace Oef24_5_Rekeningen
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
            this.goldenLabel = new System.Windows.Forms.Label();
            this.gewoonLabel = new System.Windows.Forms.Label();
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
            // goldenLabel
            // 
            this.goldenLabel.AutoSize = true;
            this.goldenLabel.Location = new System.Drawing.Point(344, 164);
            this.goldenLabel.Name = "goldenLabel";
            this.goldenLabel.Size = new System.Drawing.Size(39, 13);
            this.goldenLabel.TabIndex = 24;
            this.goldenLabel.Text = "Label1";
            // 
            // gewoonLabel
            // 
            this.gewoonLabel.AutoSize = true;
            this.gewoonLabel.Location = new System.Drawing.Point(8, 164);
            this.gewoonLabel.Name = "gewoonLabel";
            this.gewoonLabel.Size = new System.Drawing.Size(39, 13);
            this.gewoonLabel.TabIndex = 25;
            this.gewoonLabel.Text = "Label1";
            // 
            // renteGoldenLabel
            // 
            this.renteGoldenLabel.Location = new System.Drawing.Point(422, 314);
            this.renteGoldenLabel.Name = "renteGoldenLabel";
            this.renteGoldenLabel.Size = new System.Drawing.Size(100, 23);
            this.renteGoldenLabel.TabIndex = 23;
            this.renteGoldenLabel.Text = "Label3";
            // 
            // renteGewoonLabel
            // 
            this.renteGewoonLabel.Location = new System.Drawing.Point(102, 314);
            this.renteGewoonLabel.Name = "renteGewoonLabel";
            this.renteGewoonLabel.Size = new System.Drawing.Size(100, 23);
            this.renteGewoonLabel.TabIndex = 22;
            this.renteGewoonLabel.Text = "Label3";
            // 
            // renteButton
            // 
            this.renteButton.Location = new System.Drawing.Point(6, 266);
            this.renteButton.Name = "renteButton";
            this.renteButton.Size = new System.Drawing.Size(616, 23);
            this.renteButton.TabIndex = 21;
            this.renteButton.Text = "Rente";
            this.renteButton.Click += new System.EventHandler(this.ButtonRente_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.stortingOpnameTextBox);
            this.GroupBox1.Location = new System.Drawing.Point(6, 10);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(616, 104);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Storting(+)/Opname(-):";
            // 
            // stortingOpnameTextBox
            // 
            this.stortingOpnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stortingOpnameTextBox.Location = new System.Drawing.Point(224, 37);
            this.stortingOpnameTextBox.Name = "stortingOpnameTextBox";
            this.stortingOpnameTextBox.Size = new System.Drawing.Size(152, 31);
            this.stortingOpnameTextBox.TabIndex = 0;
            this.stortingOpnameTextBox.Text = "TextBox1";
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(342, 130);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(280, 34);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "Golden Rekening";
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(6, 130);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(296, 34);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "Gewone Rekening";
            // 
            // saldoGoldenLabel
            // 
            this.saldoGoldenLabel.Location = new System.Drawing.Point(422, 234);
            this.saldoGoldenLabel.Name = "saldoGoldenLabel";
            this.saldoGoldenLabel.Size = new System.Drawing.Size(100, 23);
            this.saldoGoldenLabel.TabIndex = 17;
            this.saldoGoldenLabel.Text = "Label3";
            // 
            // saldoButton
            // 
            this.saldoButton.Location = new System.Drawing.Point(6, 194);
            this.saldoButton.Name = "saldoButton";
            this.saldoButton.Size = new System.Drawing.Size(616, 23);
            this.saldoButton.TabIndex = 16;
            this.saldoButton.Text = "Saldo";
            this.saldoButton.Click += new System.EventHandler(this.ButtonSaldo_Click);
            // 
            // saldoGewoonLabel
            // 
            this.saldoGewoonLabel.Location = new System.Drawing.Point(102, 234);
            this.saldoGewoonLabel.Name = "saldoGewoonLabel";
            this.saldoGewoonLabel.Size = new System.Drawing.Size(100, 23);
            this.saldoGewoonLabel.TabIndex = 15;
            this.saldoGewoonLabel.Text = "Label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 346);
            this.Controls.Add(this.goldenLabel);
            this.Controls.Add(this.gewoonLabel);
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
            this.Text = "Oef 24.5 Rekeningen";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label goldenLabel;
        internal System.Windows.Forms.Label gewoonLabel;
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

