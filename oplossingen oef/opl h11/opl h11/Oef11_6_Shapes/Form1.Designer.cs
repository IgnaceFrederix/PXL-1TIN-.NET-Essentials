namespace Oef11_6_Shapes
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
            this.drawingPictureBox = new System.Windows.Forms.PictureBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.circleButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.triangleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingPictureBox
            // 
            this.drawingPictureBox.BackColor = System.Drawing.Color.White;
            this.drawingPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawingPictureBox.Location = new System.Drawing.Point(96, 15);
            this.drawingPictureBox.Name = "drawingPictureBox";
            this.drawingPictureBox.Size = new System.Drawing.Size(280, 200);
            this.drawingPictureBox.TabIndex = 10;
            this.drawingPictureBox.TabStop = false;
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusLabel.Location = new System.Drawing.Point(8, 223);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(368, 24);
            this.statusLabel.TabIndex = 9;
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(16, 138);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(72, 24);
            this.circleButton.TabIndex = 8;
            this.circleButton.Text = "Circle";
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // squareButton
            // 
            this.squareButton.Location = new System.Drawing.Point(16, 95);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(72, 24);
            this.squareButton.TabIndex = 7;
            this.squareButton.Text = "Square";
            this.squareButton.Click += new System.EventHandler(this.squareButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Location = new System.Drawing.Point(16, 55);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(72, 24);
            this.triangleButton.TabIndex = 6;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(16, 15);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(72, 24);
            this.rectangleButton.TabIndex = 5;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 262);
            this.Controls.Add(this.drawingPictureBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.rectangleButton);
            this.Name = "Form1";
            this.Text = "Oef 11.6 2D Shapes demo";
            ((System.ComponentModel.ISupportInitialize)(this.drawingPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox drawingPictureBox;
        internal System.Windows.Forms.Label statusLabel;
        internal System.Windows.Forms.Button circleButton;
        internal System.Windows.Forms.Button squareButton;
        internal System.Windows.Forms.Button triangleButton;
        internal System.Windows.Forms.Button rectangleButton;
    }
}

