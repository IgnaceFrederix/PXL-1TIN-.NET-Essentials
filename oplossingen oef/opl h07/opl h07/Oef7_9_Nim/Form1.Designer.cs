namespace Oef7_9_Nim
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
            this.lblComputer = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbStapel = new System.Windows.Forms.ComboBox();
            this.txtAantal = new System.Windows.Forms.TextBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lblStapel3 = new System.Windows.Forms.Label();
            this.lblStapel2 = new System.Windows.Forms.Label();
            this.lblStapel1 = new System.Windows.Forms.Label();
            this.pbStapel3 = new System.Windows.Forms.ProgressBar();
            this.pbStapel2 = new System.Windows.Forms.ProgressBar();
            this.pbStapel1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(84, 337);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(0, 13);
            this.lblComputer.TabIndex = 18;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(21, 337);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 13);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Computer";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(21, 295);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 13);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "Speler";
            // 
            // cbStapel
            // 
            this.cbStapel.FormattingEnabled = true;
            this.cbStapel.Items.AddRange(new object[] {
            "Stapel 1",
            "Stapel 2",
            "Stapel 3"});
            this.cbStapel.Location = new System.Drawing.Point(148, 287);
            this.cbStapel.Name = "cbStapel";
            this.cbStapel.Size = new System.Drawing.Size(101, 21);
            this.cbStapel.TabIndex = 15;
            // 
            // txtAantal
            // 
            this.txtAantal.Location = new System.Drawing.Point(87, 288);
            this.txtAantal.Name = "txtAantal";
            this.txtAantal.Size = new System.Drawing.Size(55, 20);
            this.txtAantal.TabIndex = 14;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(255, 285);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 13;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // lblStapel3
            // 
            this.lblStapel3.Location = new System.Drawing.Point(10, 223);
            this.lblStapel3.Name = "lblStapel3";
            this.lblStapel3.Size = new System.Drawing.Size(59, 23);
            this.lblStapel3.TabIndex = 10;
            this.lblStapel3.Text = "Label1";
            this.lblStapel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStapel2
            // 
            this.lblStapel2.Location = new System.Drawing.Point(10, 134);
            this.lblStapel2.Name = "lblStapel2";
            this.lblStapel2.Size = new System.Drawing.Size(59, 23);
            this.lblStapel2.TabIndex = 11;
            this.lblStapel2.Text = "Label1";
            this.lblStapel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStapel1
            // 
            this.lblStapel1.Location = new System.Drawing.Point(10, 47);
            this.lblStapel1.Name = "lblStapel1";
            this.lblStapel1.Size = new System.Drawing.Size(59, 23);
            this.lblStapel1.TabIndex = 12;
            this.lblStapel1.Text = "Label1";
            this.lblStapel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbStapel3
            // 
            this.pbStapel3.Location = new System.Drawing.Point(87, 188);
            this.pbStapel3.Maximum = 200;
            this.pbStapel3.Name = "pbStapel3";
            this.pbStapel3.Size = new System.Drawing.Size(367, 58);
            this.pbStapel3.Step = 1;
            this.pbStapel3.TabIndex = 7;
            // 
            // pbStapel2
            // 
            this.pbStapel2.Location = new System.Drawing.Point(87, 99);
            this.pbStapel2.Maximum = 200;
            this.pbStapel2.Name = "pbStapel2";
            this.pbStapel2.Size = new System.Drawing.Size(367, 58);
            this.pbStapel2.Step = 1;
            this.pbStapel2.TabIndex = 8;
            // 
            // pbStapel1
            // 
            this.pbStapel1.Location = new System.Drawing.Point(87, 12);
            this.pbStapel1.Maximum = 200;
            this.pbStapel1.Name = "pbStapel1";
            this.pbStapel1.Size = new System.Drawing.Size(367, 58);
            this.pbStapel1.Step = 1;
            this.pbStapel1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 365);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbStapel);
            this.Controls.Add(this.txtAantal);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.lblStapel3);
            this.Controls.Add(this.lblStapel2);
            this.Controls.Add(this.lblStapel1);
            this.Controls.Add(this.pbStapel3);
            this.Controls.Add(this.pbStapel2);
            this.Controls.Add(this.pbStapel1);
            this.Name = "Form1";
            this.Text = "Oef 7.9 Nim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblComputer;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbStapel;
        internal System.Windows.Forms.TextBox txtAantal;
        internal System.Windows.Forms.Button btnVerwijder;
        internal System.Windows.Forms.Label lblStapel3;
        internal System.Windows.Forms.Label lblStapel2;
        internal System.Windows.Forms.Label lblStapel1;
        internal System.Windows.Forms.ProgressBar pbStapel3;
        internal System.Windows.Forms.ProgressBar pbStapel2;
        internal System.Windows.Forms.ProgressBar pbStapel1;
    }
}

