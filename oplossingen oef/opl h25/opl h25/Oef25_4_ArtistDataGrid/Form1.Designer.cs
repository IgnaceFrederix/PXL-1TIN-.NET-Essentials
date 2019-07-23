namespace Oef25_4_ArtistDataGrid
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
            this.artistGridView = new System.Windows.Forms.DataGridView();
            this.toonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.artistGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // artistGridView
            // 
            this.artistGridView.AllowUserToAddRows = false;
            this.artistGridView.AllowUserToDeleteRows = false;
            this.artistGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.artistGridView.Location = new System.Drawing.Point(17, 12);
            this.artistGridView.Name = "artistGridView";
            this.artistGridView.ReadOnly = true;
            this.artistGridView.Size = new System.Drawing.Size(399, 186);
            this.artistGridView.TabIndex = 3;
            // 
            // toonButton
            // 
            this.toonButton.Location = new System.Drawing.Point(190, 227);
            this.toonButton.Name = "toonButton";
            this.toonButton.Size = new System.Drawing.Size(75, 23);
            this.toonButton.TabIndex = 2;
            this.toonButton.Text = "Toon";
            this.toonButton.UseVisualStyleBackColor = true;
            this.toonButton.Click += new System.EventHandler(this.artistGridView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 262);
            this.Controls.Add(this.artistGridView);
            this.Controls.Add(this.toonButton);
            this.Name = "Form1";
            this.Text = "Oef 25.4 Artist DataGrid";
            ((System.ComponentModel.ISupportInitialize)(this.artistGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView artistGridView;
        internal System.Windows.Forms.Button toonButton;
    }
}

