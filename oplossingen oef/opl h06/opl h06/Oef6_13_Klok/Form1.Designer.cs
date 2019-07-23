namespace Oef6_13_Klok
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
            this.secLabel = new System.Windows.Forms.Label();
            this.urenLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.klokPanel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.klokPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // secLabel
            // 
            this.secLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.secLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLabel.ForeColor = System.Drawing.Color.Red;
            this.secLabel.Location = new System.Drawing.Point(236, 252);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(40, 23);
            this.secLabel.TabIndex = 16;
            // 
            // urenLabel
            // 
            this.urenLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.urenLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.urenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urenLabel.ForeColor = System.Drawing.Color.Black;
            this.urenLabel.Location = new System.Drawing.Point(60, 252);
            this.urenLabel.Name = "urenLabel";
            this.urenLabel.Size = new System.Drawing.Size(40, 23);
            this.urenLabel.TabIndex = 15;
            // 
            // minLabel
            // 
            this.minLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.minLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.Blue;
            this.minLabel.Location = new System.Drawing.Point(148, 252);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(40, 23);
            this.minLabel.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(204, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sec:";
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(116, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Min:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Uren:";
            // 
            // klokPanel
            // 
            this.klokPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.klokPanel.Location = new System.Drawing.Point(12, 12);
            this.klokPanel.Name = "klokPanel";
            this.klokPanel.Size = new System.Drawing.Size(296, 216);
            this.klokPanel.TabIndex = 10;
            this.klokPanel.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(324, 289);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.urenLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klokPanel);
            this.Name = "Form1";
            this.Text = "Oef 6.13 .NET Klok applicatie";
            ((System.ComponentModel.ISupportInitialize)(this.klokPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label secLabel;
        internal System.Windows.Forms.Label urenLabel;
        internal System.Windows.Forms.Label minLabel;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Timer myTimer;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox klokPanel;
    }
}

