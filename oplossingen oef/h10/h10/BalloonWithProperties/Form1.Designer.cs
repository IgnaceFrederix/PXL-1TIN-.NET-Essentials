namespace BalloonWithProperties
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
            this.moveButton = new System.Windows.Forms.Button();
            this.growButton = new System.Windows.Forms.Button();
            this.balloonPictureBox = new System.Windows.Forms.PictureBox();
            this.displayXButton = new System.Windows.Forms.Button();
            this.changeXButton = new System.Windows.Forms.Button();
            this.xCoordTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.balloonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(12, 81);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(75, 23);
            this.moveButton.TabIndex = 0;
            this.moveButton.Text = "Move";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // growButton
            // 
            this.growButton.Location = new System.Drawing.Point(12, 133);
            this.growButton.Name = "growButton";
            this.growButton.Size = new System.Drawing.Size(75, 23);
            this.growButton.TabIndex = 0;
            this.growButton.Text = "Grow";
            this.growButton.UseVisualStyleBackColor = true;
            this.growButton.Click += new System.EventHandler(this.growButton_Click);
            // 
            // balloonPictureBox
            // 
            this.balloonPictureBox.BackColor = System.Drawing.Color.White;
            this.balloonPictureBox.Location = new System.Drawing.Point(113, 56);
            this.balloonPictureBox.Name = "balloonPictureBox";
            this.balloonPictureBox.Size = new System.Drawing.Size(193, 194);
            this.balloonPictureBox.TabIndex = 1;
            this.balloonPictureBox.TabStop = false;
            // 
            // displayXButton
            // 
            this.displayXButton.Location = new System.Drawing.Point(12, 12);
            this.displayXButton.Name = "displayXButton";
            this.displayXButton.Size = new System.Drawing.Size(75, 23);
            this.displayXButton.TabIndex = 0;
            this.displayXButton.Text = "Display x";
            this.displayXButton.UseVisualStyleBackColor = true;
            this.displayXButton.Click += new System.EventHandler(this.displayXButton_Click);
            // 
            // changeXButton
            // 
            this.changeXButton.Location = new System.Drawing.Point(231, 12);
            this.changeXButton.Name = "changeXButton";
            this.changeXButton.Size = new System.Drawing.Size(75, 23);
            this.changeXButton.TabIndex = 0;
            this.changeXButton.Text = "Change x";
            this.changeXButton.UseVisualStyleBackColor = true;
            this.changeXButton.Click += new System.EventHandler(this.changeXButton_Click);
            // 
            // xCoordTextBox
            // 
            this.xCoordTextBox.Location = new System.Drawing.Point(135, 15);
            this.xCoordTextBox.Name = "xCoordTextBox";
            this.xCoordTextBox.Size = new System.Drawing.Size(45, 20);
            this.xCoordTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(318, 262);
            this.Controls.Add(this.xCoordTextBox);
            this.Controls.Add(this.balloonPictureBox);
            this.Controls.Add(this.growButton);
            this.Controls.Add(this.changeXButton);
            this.Controls.Add(this.displayXButton);
            this.Controls.Add(this.moveButton);
            this.Name = "Form1";
            this.Text = "Balloon with properties";
            ((System.ComponentModel.ISupportInitialize)(this.balloonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button growButton;
        private System.Windows.Forms.PictureBox balloonPictureBox;
        private System.Windows.Forms.Button displayXButton;
        private System.Windows.Forms.Button changeXButton;
        private System.Windows.Forms.TextBox xCoordTextBox;
    }
}

