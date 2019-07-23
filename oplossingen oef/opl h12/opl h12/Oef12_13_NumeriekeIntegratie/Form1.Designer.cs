namespace Oef12_13_NumeriekeIntegratie
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
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(269, 37);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(75, 23);
            this.btnBereken.TabIndex = 9;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(39, 128);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(305, 124);
            this.txtResult.TabIndex = 8;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(36, 99);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(139, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Oppervlakte tussen 0 en PI:";
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(206, 39);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(42, 20);
            this.txtAantal.TabIndex = 6;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(36, 42);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(167, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "d (aantal intervals tussen 0 en PI):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 289);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Oef 12.13 Numerieke integratie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnBereken;
        internal System.Windows.Forms.TextBox txtResult;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtAantal;
        internal System.Windows.Forms.Label Label1;
    }
}

