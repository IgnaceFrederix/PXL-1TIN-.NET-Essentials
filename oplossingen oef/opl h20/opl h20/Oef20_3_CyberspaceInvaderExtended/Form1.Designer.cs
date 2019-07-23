namespace Oef20_3_CyberspaceInvaderExtended
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AlienImage = new System.Windows.Forms.PictureBox();
            this.UserImage = new System.Windows.Forms.PictureBox();
            this.gamePictureBox = new System.Windows.Forms.PictureBox();
            this.BombTimer = new System.Windows.Forms.Timer(this.components);
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AlienImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AlienImage
            // 
            this.AlienImage.Image = ((System.Drawing.Image)(resources.GetObject("AlienImage.Image")));
            this.AlienImage.Location = new System.Drawing.Point(157, 172);
            this.AlienImage.Name = "AlienImage";
            this.AlienImage.Size = new System.Drawing.Size(64, 48);
            this.AlienImage.TabIndex = 6;
            this.AlienImage.TabStop = false;
            this.AlienImage.Visible = false;
            // 
            // UserImage
            // 
            this.UserImage.Image = ((System.Drawing.Image)(resources.GetObject("UserImage.Image")));
            this.UserImage.Location = new System.Drawing.Point(53, 172);
            this.UserImage.Name = "UserImage";
            this.UserImage.Size = new System.Drawing.Size(56, 48);
            this.UserImage.TabIndex = 5;
            this.UserImage.TabStop = false;
            this.UserImage.Visible = false;
            // 
            // PictureBox1
            // 
            this.gamePictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.gamePictureBox.Location = new System.Drawing.Point(21, 12);
            this.gamePictureBox.Name = "PictureBox1";
            this.gamePictureBox.Size = new System.Drawing.Size(264, 248);
            this.gamePictureBox.TabIndex = 4;
            this.gamePictureBox.TabStop = false;
            this.gamePictureBox.Click += new System.EventHandler(this.gamePictureBox_Click);
            this.gamePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gamePictureBox_MouseMove);
            // 
            // BombTimer
            // 
            this.BombTimer.Enabled = true;
            this.BombTimer.Interval = 1000;
            this.BombTimer.Tick += new System.EventHandler(this.bombTimer_Tick);
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Enabled = true;
            this.AnimationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(154, 272);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.ScoreLabel.TabIndex = 7;
            this.ScoreLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 302);
            this.Controls.Add(this.AlienImage);
            this.Controls.Add(this.UserImage);
            this.Controls.Add(this.gamePictureBox);
            this.Controls.Add(this.ScoreLabel);
            this.Name = "Form1";
            this.Text = "Oef 20.3 Cyberspace invader extended";
            ((System.ComponentModel.ISupportInitialize)(this.AlienImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox AlienImage;
        internal System.Windows.Forms.PictureBox UserImage;
        internal System.Windows.Forms.PictureBox gamePictureBox;
        internal System.Windows.Forms.Timer BombTimer;
        internal System.Windows.Forms.Timer AnimationTimer;
        internal System.Windows.Forms.Label ScoreLabel;
    }
}

