namespace Oef20_2_CyberspaceInvader
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.gamePictureBox = new System.Windows.Forms.PictureBox();
            this.alienPictureBox = new System.Windows.Forms.PictureBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.bombTimer = new System.Windows.Forms.Timer(this.components);
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePictureBox
            // 
            this.gamePictureBox.BackColor = System.Drawing.Color.White;
            this.gamePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePictureBox.Location = new System.Drawing.Point(0, 0);
            this.gamePictureBox.Name = "gamePictureBox";
            this.gamePictureBox.Size = new System.Drawing.Size(250, 250);
            this.gamePictureBox.TabIndex = 0;
            this.gamePictureBox.TabStop = false;
            this.gamePictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gamePictureBox_MouseClick);
            this.gamePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gamePictureBox_MouseMove);
            // 
            // alienPictureBox
            // 
            this.alienPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("alienPictureBox.Image")));
            this.alienPictureBox.Location = new System.Drawing.Point(68, 147);
            this.alienPictureBox.Name = "alienPictureBox";
            this.alienPictureBox.Size = new System.Drawing.Size(61, 33);
            this.alienPictureBox.TabIndex = 1;
            this.alienPictureBox.TabStop = false;
            this.alienPictureBox.Visible = false;
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBox.Image")));
            this.userPictureBox.Location = new System.Drawing.Point(68, 91);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(61, 50);
            this.userPictureBox.TabIndex = 2;
            this.userPictureBox.TabStop = false;
            this.userPictureBox.Visible = false;
            // 
            // bombTimer
            // 
            this.bombTimer.Enabled = true;
            this.bombTimer.Interval = 2000;
            this.bombTimer.Tick += new System.EventHandler(this.bombTimer_Tick);
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Interval = 50;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.alienPictureBox);
            this.Controls.Add(this.gamePictureBox);
            this.Name = "Game";
            this.Text = "Oef 20.2 Cyberspace invader";
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alienPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gamePictureBox;
        private System.Windows.Forms.PictureBox alienPictureBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Timer bombTimer;
        private System.Windows.Forms.Timer animationTimer;
    }
}

