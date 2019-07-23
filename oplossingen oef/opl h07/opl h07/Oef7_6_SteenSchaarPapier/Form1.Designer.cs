namespace Oef7_6_SteenSchaarPapier
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
            this.progressPictureBox = new System.Windows.Forms.PictureBox();
            this.opnieuwButton = new System.Windows.Forms.Button();
            this.spelTimer = new System.Windows.Forms.Timer(this.components);
            this.winVerliesLabel = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblKeuze = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.gebruikerLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.papierButton = new System.Windows.Forms.Button();
            this.schaarButton = new System.Windows.Forms.Button();
            this.steenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.progressPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // progressPictureBox
            // 
            this.progressPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.progressPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressPictureBox.Location = new System.Drawing.Point(82, 372);
            this.progressPictureBox.Name = "progressPictureBox";
            this.progressPictureBox.Size = new System.Drawing.Size(264, 8);
            this.progressPictureBox.TabIndex = 24;
            this.progressPictureBox.TabStop = false;
            // 
            // opnieuwButton
            // 
            this.opnieuwButton.Location = new System.Drawing.Point(366, 324);
            this.opnieuwButton.Name = "opnieuwButton";
            this.opnieuwButton.Size = new System.Drawing.Size(64, 56);
            this.opnieuwButton.TabIndex = 23;
            this.opnieuwButton.Text = "Opnieuw";
            this.opnieuwButton.Visible = false;
            this.opnieuwButton.Click += new System.EventHandler(this.opnieuwButton_Click);
            // 
            // spelTimer
            // 
            this.spelTimer.Interval = 1000;
            this.spelTimer.Tick += new System.EventHandler(this.spelTimer_Tick);
            // 
            // winVerliesLabel
            // 
            this.winVerliesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winVerliesLabel.Location = new System.Drawing.Point(18, 116);
            this.winVerliesLabel.Name = "winVerliesLabel";
            this.winVerliesLabel.Size = new System.Drawing.Size(400, 48);
            this.winVerliesLabel.TabIndex = 22;
            this.winVerliesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(194, 332);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 24);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "JIJ";
            // 
            // lblKeuze
            // 
            this.lblKeuze.Location = new System.Drawing.Point(162, 300);
            this.lblKeuze.Name = "lblKeuze";
            this.lblKeuze.Size = new System.Drawing.Size(100, 23);
            this.lblKeuze.TabIndex = 20;
            this.lblKeuze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(138, 276);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(152, 24);
            this.Label2.TabIndex = 19;
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gebruikerLabel
            // 
            this.gebruikerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gebruikerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebruikerLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gebruikerLabel.Location = new System.Drawing.Point(122, 180);
            this.gebruikerLabel.Name = "gebruikerLabel";
            this.gebruikerLabel.Size = new System.Drawing.Size(192, 48);
            this.gebruikerLabel.TabIndex = 18;
            this.gebruikerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // computerLabel
            // 
            this.computerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerLabel.Location = new System.Drawing.Point(122, 60);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(192, 48);
            this.computerLabel.TabIndex = 17;
            this.computerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(154, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 24);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "COMPUTER";
            // 
            // papierButton
            // 
            this.papierButton.Location = new System.Drawing.Point(282, 244);
            this.papierButton.Name = "papierButton";
            this.papierButton.Size = new System.Drawing.Size(75, 23);
            this.papierButton.TabIndex = 15;
            this.papierButton.Text = "Papier";
            // 
            // schaarButton
            // 
            this.schaarButton.Location = new System.Drawing.Point(178, 244);
            this.schaarButton.Name = "schaarButton";
            this.schaarButton.Size = new System.Drawing.Size(75, 23);
            this.schaarButton.TabIndex = 14;
            this.schaarButton.Text = "Schaar";
            // 
            // steenButton
            // 
            this.steenButton.Location = new System.Drawing.Point(74, 244);
            this.steenButton.Name = "steenButton";
            this.steenButton.Size = new System.Drawing.Size(75, 23);
            this.steenButton.TabIndex = 13;
            this.steenButton.Text = "Steen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 436);
            this.Controls.Add(this.progressPictureBox);
            this.Controls.Add(this.opnieuwButton);
            this.Controls.Add(this.winVerliesLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.lblKeuze);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.gebruikerLabel);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.papierButton);
            this.Controls.Add(this.schaarButton);
            this.Controls.Add(this.steenButton);
            this.Name = "Form1";
            this.Text = "Oef 7.6 Steen, schaar, papier";
            ((System.ComponentModel.ISupportInitialize)(this.progressPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox progressPictureBox;
        internal System.Windows.Forms.Button opnieuwButton;
        internal System.Windows.Forms.Timer spelTimer;
        internal System.Windows.Forms.Label winVerliesLabel;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblKeuze;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label gebruikerLabel;
        internal System.Windows.Forms.Label computerLabel;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button papierButton;
        internal System.Windows.Forms.Button schaarButton;
        internal System.Windows.Forms.Button steenButton;
    }
}

