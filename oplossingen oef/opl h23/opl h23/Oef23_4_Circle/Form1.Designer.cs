﻿namespace Oef23_4_Circle
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
            this.shapesPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.shapesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shapesPictureBox
            // 
            this.shapesPictureBox.BackColor = System.Drawing.Color.White;
            this.shapesPictureBox.Location = new System.Drawing.Point(6, 7);
            this.shapesPictureBox.Name = "shapesPictureBox";
            this.shapesPictureBox.Size = new System.Drawing.Size(273, 249);
            this.shapesPictureBox.TabIndex = 1;
            this.shapesPictureBox.TabStop = false;
            this.shapesPictureBox.Click += new System.EventHandler(this.shapesPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.shapesPictureBox);
            this.Name = "Form1";
            this.Text = "Oef 23.4 Shapes met interfaces";
            ((System.ComponentModel.ISupportInitialize)(this.shapesPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox shapesPictureBox;
    }
}

