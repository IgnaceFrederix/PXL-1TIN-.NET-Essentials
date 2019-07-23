namespace Oef6_7_Meetkundespelletje
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
            this.actionButton = new System.Windows.Forms.Button();
            this.lblTijd = new System.Windows.Forms.Label();
            this.vertTrackBar = new System.Windows.Forms.TrackBar();
            this.spelPictureBox = new System.Windows.Forms.PictureBox();
            this.spelTimer = new System.Windows.Forms.Timer(this.components);
            this.diamTrackBar = new System.Windows.Forms.TrackBar();
            this.horizTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.vertTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(212, 252);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(75, 23);
            this.actionButton.TabIndex = 12;
            this.actionButton.Text = "Start";
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // lblTijd
            // 
            this.lblTijd.Location = new System.Drawing.Point(220, 228);
            this.lblTijd.Name = "lblTijd";
            this.lblTijd.Size = new System.Drawing.Size(64, 23);
            this.lblTijd.TabIndex = 11;
            // 
            // vertTrackBar
            // 
            this.vertTrackBar.Location = new System.Drawing.Point(228, 12);
            this.vertTrackBar.Maximum = 200;
            this.vertTrackBar.Name = "vertTrackBar";
            this.vertTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vertTrackBar.Size = new System.Drawing.Size(45, 200);
            this.vertTrackBar.TabIndex = 8;
            this.vertTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.vertTrackBar.Scroll += new System.EventHandler(this.vertTrackBar_Scroll);
            // 
            // spelPictureBox
            // 
            this.spelPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.spelPictureBox.Location = new System.Drawing.Point(12, 12);
            this.spelPictureBox.Name = "spelPictureBox";
            this.spelPictureBox.Size = new System.Drawing.Size(200, 200);
            this.spelPictureBox.TabIndex = 7;
            this.spelPictureBox.TabStop = false;
            // 
            // spelTimer
            // 
            this.spelTimer.Interval = 1000;
            this.spelTimer.Tick += new System.EventHandler(this.spelTimer_Tick);
            // 
            // diamTrackBar
            // 
            this.diamTrackBar.Location = new System.Drawing.Point(12, 260);
            this.diamTrackBar.Maximum = 200;
            this.diamTrackBar.Name = "diamTrackBar";
            this.diamTrackBar.Size = new System.Drawing.Size(200, 45);
            this.diamTrackBar.TabIndex = 10;
            this.diamTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.diamTrackBar.Scroll += new System.EventHandler(this.diamTrackBar_Scroll);
            // 
            // horizTrackBar
            // 
            this.horizTrackBar.Location = new System.Drawing.Point(12, 212);
            this.horizTrackBar.Maximum = 200;
            this.horizTrackBar.Name = "horizTrackBar";
            this.horizTrackBar.Size = new System.Drawing.Size(200, 45);
            this.horizTrackBar.TabIndex = 9;
            this.horizTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.horizTrackBar.Scroll += new System.EventHandler(this.horizTrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 305);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.lblTijd);
            this.Controls.Add(this.vertTrackBar);
            this.Controls.Add(this.spelPictureBox);
            this.Controls.Add(this.diamTrackBar);
            this.Controls.Add(this.horizTrackBar);
            this.Name = "Form1";
            this.Text = "Oef 6.7 Meetkundespelletje";
            ((System.ComponentModel.ISupportInitialize)(this.vertTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diamTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button actionButton;
        internal System.Windows.Forms.Label lblTijd;
        internal System.Windows.Forms.TrackBar vertTrackBar;
        internal System.Windows.Forms.PictureBox spelPictureBox;
        internal System.Windows.Forms.Timer spelTimer;
        internal System.Windows.Forms.TrackBar diamTrackBar;
        internal System.Windows.Forms.TrackBar horizTrackBar;
    }
}

