namespace TestVraag7_5
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
            this.salaryTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loonLabel = new System.Windows.Forms.Label();
            this.belastingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaryTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // salaryTrackBar
            // 
            this.salaryTrackBar.Location = new System.Drawing.Point(12, 12);
            this.salaryTrackBar.Maximum = 100000;
            this.salaryTrackBar.Name = "salaryTrackBar";
            this.salaryTrackBar.Size = new System.Drawing.Size(260, 45);
            this.salaryTrackBar.SmallChange = 10000;
            this.salaryTrackBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "loon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "belastingen:";
            // 
            // loonLabel
            // 
            this.loonLabel.AutoSize = true;
            this.loonLabel.Location = new System.Drawing.Point(111, 73);
            this.loonLabel.Name = "loonLabel";
            this.loonLabel.Size = new System.Drawing.Size(0, 13);
            this.loonLabel.TabIndex = 1;
            // 
            // belastingLabel
            // 
            this.belastingLabel.AutoSize = true;
            this.belastingLabel.Location = new System.Drawing.Point(111, 105);
            this.belastingLabel.Name = "belastingLabel";
            this.belastingLabel.Size = new System.Drawing.Size(0, 13);
            this.belastingLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.belastingLabel);
            this.Controls.Add(this.loonLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salaryTrackBar);
            this.Name = "Form1";
            this.Text = "Belastingen";
            ((System.ComponentModel.ISupportInitialize)(this.salaryTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar salaryTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loonLabel;
        private System.Windows.Forms.Label belastingLabel;
    }
}

