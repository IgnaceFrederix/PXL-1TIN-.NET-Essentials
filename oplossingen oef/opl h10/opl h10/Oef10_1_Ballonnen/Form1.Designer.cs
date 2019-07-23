namespace Oef10_1_Ballonnen
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
            this.toonNaamEnKleurButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.growButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.balloonPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.balloonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toonNaamEnKleurButton
            // 
            this.toonNaamEnKleurButton.Location = new System.Drawing.Point(52, 15);
            this.toonNaamEnKleurButton.Name = "toonNaamEnKleurButton";
            this.toonNaamEnKleurButton.Size = new System.Drawing.Size(120, 23);
            this.toonNaamEnKleurButton.TabIndex = 16;
            this.toonNaamEnKleurButton.Text = "Toon naam en kleur";
            this.toonNaamEnKleurButton.Click += new System.EventHandler(this.toonNaamEnKleurButton_Click);
            // 
            // moveDownButton
            // 
            this.moveDownButton.Location = new System.Drawing.Point(92, 191);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(78, 32);
            this.moveDownButton.TabIndex = 15;
            this.moveDownButton.Text = "Move Down";
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Location = new System.Drawing.Point(92, 79);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(78, 32);
            this.moveUpButton.TabIndex = 14;
            this.moveUpButton.Text = "Move Up";
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.Location = new System.Drawing.Point(36, 135);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(78, 32);
            this.moveLeftButton.TabIndex = 13;
            this.moveLeftButton.Text = "Move Left";
            this.moveLeftButton.Click += new System.EventHandler(this.moveLeftButton_Click);
            // 
            // growButton
            // 
            this.growButton.Location = new System.Drawing.Point(292, 15);
            this.growButton.Name = "growButton";
            this.growButton.Size = new System.Drawing.Size(48, 24);
            this.growButton.TabIndex = 12;
            this.growButton.Text = "Grow";
            this.growButton.Click += new System.EventHandler(this.growButton_Click);
            // 
            // moveRightButton
            // 
            this.moveRightButton.Location = new System.Drawing.Point(140, 135);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(78, 32);
            this.moveRightButton.TabIndex = 11;
            this.moveRightButton.Text = "Move Right";
            this.moveRightButton.Click += new System.EventHandler(this.moveRightButton_Click);
            // 
            // balloonPictureBox
            // 
            this.balloonPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.balloonPictureBox.Location = new System.Drawing.Point(236, 71);
            this.balloonPictureBox.Name = "balloonPictureBox";
            this.balloonPictureBox.Size = new System.Drawing.Size(168, 176);
            this.balloonPictureBox.TabIndex = 10;
            this.balloonPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 262);
            this.Controls.Add(this.toonNaamEnKleurButton);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.moveLeftButton);
            this.Controls.Add(this.growButton);
            this.Controls.Add(this.moveRightButton);
            this.Controls.Add(this.balloonPictureBox);
            this.Name = "Form1";
            this.Text = "Oef 10.1 Ballonnen";
            ((System.ComponentModel.ISupportInitialize)(this.balloonPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button toonNaamEnKleurButton;
        internal System.Windows.Forms.Button moveDownButton;
        internal System.Windows.Forms.Button moveUpButton;
        internal System.Windows.Forms.Button moveLeftButton;
        internal System.Windows.Forms.Button growButton;
        internal System.Windows.Forms.Button moveRightButton;
        internal System.Windows.Forms.PictureBox balloonPictureBox;
    }
}

