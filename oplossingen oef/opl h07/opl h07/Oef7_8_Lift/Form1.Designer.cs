namespace Oef7_8_Lift
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
            this.omlaagButton = new System.Windows.Forms.Button();
            this.omhoogButton = new System.Windows.Forms.Button();
            this.liftPictureBox = new System.Windows.Forms.PictureBox();
            this.liftTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.liftPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // omlaagButton
            // 
            this.omlaagButton.Enabled = false;
            this.omlaagButton.Location = new System.Drawing.Point(196, 90);
            this.omlaagButton.Name = "omlaagButton";
            this.omlaagButton.Size = new System.Drawing.Size(56, 56);
            this.omlaagButton.TabIndex = 5;
            this.omlaagButton.Text = "Omlaag";
            this.omlaagButton.Click += new System.EventHandler(this.omlaagButton_Click);
            // 
            // omhoogButton
            // 
            this.omhoogButton.Enabled = false;
            this.omhoogButton.Location = new System.Drawing.Point(196, 26);
            this.omhoogButton.Name = "omhoogButton";
            this.omhoogButton.Size = new System.Drawing.Size(56, 56);
            this.omhoogButton.TabIndex = 4;
            this.omhoogButton.Text = "Omhoog";
            this.omhoogButton.Click += new System.EventHandler(this.omhoogButton_Click);
            // 
            // liftPictureBox
            // 
            this.liftPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.liftPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.liftPictureBox.Location = new System.Drawing.Point(38, 26);
            this.liftPictureBox.Name = "liftPictureBox";
            this.liftPictureBox.Size = new System.Drawing.Size(120, 560);
            this.liftPictureBox.TabIndex = 3;
            this.liftPictureBox.TabStop = false;
            this.liftPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.liftPictureBox_Paint);
            // 
            // liftTimer
            // 
            this.liftTimer.Tick += new System.EventHandler(this.liftTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 604);
            this.Controls.Add(this.omlaagButton);
            this.Controls.Add(this.omhoogButton);
            this.Controls.Add(this.liftPictureBox);
            this.Name = "Form1";
            this.Text = "Oef 7.8 De lift";
            ((System.ComponentModel.ISupportInitialize)(this.liftPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button omlaagButton;
        internal System.Windows.Forms.Button omhoogButton;
        internal System.Windows.Forms.PictureBox liftPictureBox;
        internal System.Windows.Forms.Timer liftTimer;
    }
}

