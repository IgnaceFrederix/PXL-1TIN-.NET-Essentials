namespace Oef7_2_Sorteren
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
            this.resultaatLabel = new System.Windows.Forms.Label();
            this.getal3Label = new System.Windows.Forms.Label();
            this.getal2Label = new System.Windows.Forms.Label();
            this.getal1Label = new System.Windows.Forms.Label();
            this.sorteerButton = new System.Windows.Forms.Button();
            this.getal3TrackBar = new System.Windows.Forms.TrackBar();
            this.getal2TrackBar = new System.Windows.Forms.TrackBar();
            this.getal1TrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.getal3TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getal2TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getal1TrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // resultaatLabel
            // 
            this.resultaatLabel.AutoSize = true;
            this.resultaatLabel.Location = new System.Drawing.Point(75, 231);
            this.resultaatLabel.Name = "resultaatLabel";
            this.resultaatLabel.Size = new System.Drawing.Size(0, 13);
            this.resultaatLabel.TabIndex = 15;
            // 
            // getal3Label
            // 
            this.getal3Label.Location = new System.Drawing.Point(347, 122);
            this.getal3Label.Name = "getal3Label";
            this.getal3Label.Size = new System.Drawing.Size(100, 23);
            this.getal3Label.TabIndex = 14;
            // 
            // getal2Label
            // 
            this.getal2Label.Location = new System.Drawing.Point(347, 74);
            this.getal2Label.Name = "getal2Label";
            this.getal2Label.Size = new System.Drawing.Size(100, 23);
            this.getal2Label.TabIndex = 13;
            // 
            // getal1Label
            // 
            this.getal1Label.Location = new System.Drawing.Point(347, 26);
            this.getal1Label.Name = "getal1Label";
            this.getal1Label.Size = new System.Drawing.Size(100, 23);
            this.getal1Label.TabIndex = 12;
            // 
            // sorteerButton
            // 
            this.sorteerButton.Location = new System.Drawing.Point(195, 186);
            this.sorteerButton.Name = "sorteerButton";
            this.sorteerButton.Size = new System.Drawing.Size(75, 23);
            this.sorteerButton.TabIndex = 11;
            this.sorteerButton.Text = "&Sorteer";
            this.sorteerButton.Click += new System.EventHandler(this.sorteerButton_Click);
            // 
            // getal3TrackBar
            // 
            this.getal3TrackBar.Location = new System.Drawing.Point(59, 114);
            this.getal3TrackBar.Name = "getal3TrackBar";
            this.getal3TrackBar.Size = new System.Drawing.Size(280, 45);
            this.getal3TrackBar.TabIndex = 10;
            this.getal3TrackBar.Scroll += new System.EventHandler(this.getal3TrackBar_Scroll);
            // 
            // getal2TrackBar
            // 
            this.getal2TrackBar.Location = new System.Drawing.Point(59, 66);
            this.getal2TrackBar.Name = "getal2TrackBar";
            this.getal2TrackBar.Size = new System.Drawing.Size(280, 45);
            this.getal2TrackBar.TabIndex = 9;
            this.getal2TrackBar.Scroll += new System.EventHandler(this.getal2TrackBar_Scroll);
            // 
            // getal1TrackBar
            // 
            this.getal1TrackBar.Location = new System.Drawing.Point(59, 18);
            this.getal1TrackBar.Name = "getal1TrackBar";
            this.getal1TrackBar.Size = new System.Drawing.Size(280, 45);
            this.getal1TrackBar.TabIndex = 8;
            this.getal1TrackBar.Scroll += new System.EventHandler(this.getal1TrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 262);
            this.Controls.Add(this.resultaatLabel);
            this.Controls.Add(this.getal3Label);
            this.Controls.Add(this.getal2Label);
            this.Controls.Add(this.getal1Label);
            this.Controls.Add(this.sorteerButton);
            this.Controls.Add(this.getal3TrackBar);
            this.Controls.Add(this.getal2TrackBar);
            this.Controls.Add(this.getal1TrackBar);
            this.Name = "Form1";
            this.Text = "Oef 7.2 Sorteren";
            ((System.ComponentModel.ISupportInitialize)(this.getal3TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getal2TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getal1TrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label resultaatLabel;
        internal System.Windows.Forms.Label getal3Label;
        internal System.Windows.Forms.Label getal2Label;
        internal System.Windows.Forms.Label getal1Label;
        internal System.Windows.Forms.Button sorteerButton;
        internal System.Windows.Forms.TrackBar getal3TrackBar;
        internal System.Windows.Forms.TrackBar getal2TrackBar;
        internal System.Windows.Forms.TrackBar getal1TrackBar;
    }
}

