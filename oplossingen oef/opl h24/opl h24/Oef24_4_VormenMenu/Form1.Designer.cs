namespace Oef24_4_VormenMenu
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lijnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechthoekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cirkelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.shapesPictureBox)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapesPictureBox
            // 
            this.shapesPictureBox.BackColor = System.Drawing.Color.White;
            this.shapesPictureBox.Location = new System.Drawing.Point(6, 36);
            this.shapesPictureBox.Name = "shapesPictureBox";
            this.shapesPictureBox.Size = new System.Drawing.Size(273, 249);
            this.shapesPictureBox.TabIndex = 1;
            this.shapesPictureBox.TabStop = false;
            this.shapesPictureBox.Click += new System.EventHandler(this.shapesPictureBox_Click);
            this.shapesPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.shapesPictureBox_Paint);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.vormToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(284, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // vormToolStripMenuItem
            // 
            this.vormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijnToolStripMenuItem,
            this.rechthoekToolStripMenuItem,
            this.cirkelToolStripMenuItem});
            this.vormToolStripMenuItem.Name = "vormToolStripMenuItem";
            this.vormToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.vormToolStripMenuItem.Text = "Vorm";
            // 
            // lijnToolStripMenuItem
            // 
            this.lijnToolStripMenuItem.Checked = true;
            this.lijnToolStripMenuItem.CheckOnClick = true;
            this.lijnToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lijnToolStripMenuItem.Name = "lijnToolStripMenuItem";
            this.lijnToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.lijnToolStripMenuItem.Tag = "";
            this.lijnToolStripMenuItem.Text = "Lijn";
            this.lijnToolStripMenuItem.Click += new System.EventHandler(this.lijnToolStripMenuItem_Click);
            // 
            // rechthoekToolStripMenuItem
            // 
            this.rechthoekToolStripMenuItem.CheckOnClick = true;
            this.rechthoekToolStripMenuItem.Name = "rechthoekToolStripMenuItem";
            this.rechthoekToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.rechthoekToolStripMenuItem.Tag = "";
            this.rechthoekToolStripMenuItem.Text = "Rechthoek";
            this.rechthoekToolStripMenuItem.Click += new System.EventHandler(this.rechthoekToolStripMenuItem_Click);
            // 
            // cirkelToolStripMenuItem
            // 
            this.cirkelToolStripMenuItem.CheckOnClick = true;
            this.cirkelToolStripMenuItem.Name = "cirkelToolStripMenuItem";
            this.cirkelToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cirkelToolStripMenuItem.Tag = "";
            this.cirkelToolStripMenuItem.Text = "Cirkel";
            this.cirkelToolStripMenuItem.Click += new System.EventHandler(this.cirkelToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.shapesPictureBox);
            this.Name = "Form1";
            this.Text = "Oef 24.4 Vormen menu";
            ((System.ComponentModel.ISupportInitialize)(this.shapesPictureBox)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox shapesPictureBox;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem vormToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem lijnToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem rechthoekToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem cirkelToolStripMenuItem;
    }
}

