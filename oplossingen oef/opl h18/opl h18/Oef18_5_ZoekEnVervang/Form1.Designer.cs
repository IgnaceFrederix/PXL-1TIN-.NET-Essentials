namespace Oef18_5_ZoekEnVervang
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
            this.convertButton = new System.Windows.Forms.Button();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.LabelTo = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.LabelFrom = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(468, 261);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(208, 48);
            this.convertButton.TabIndex = 17;
            this.convertButton.Text = "Convert";
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationTextBox.Location = new System.Drawing.Point(12, 101);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(664, 26);
            this.destinationTextBox.TabIndex = 15;
            this.destinationTextBox.Text = "Filename destination";
            // 
            // LabelTo
            // 
            this.LabelTo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTo.Location = new System.Drawing.Point(20, 232);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(48, 16);
            this.LabelTo.TabIndex = 14;
            this.LabelTo.Text = "To";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(548, 133);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(128, 24);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save as";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toTextBox
            // 
            this.toTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTextBox.Location = new System.Drawing.Point(76, 229);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(600, 26);
            this.toTextBox.TabIndex = 13;
            this.toTextBox.Text = "To string";
            // 
            // LabelFrom
            // 
            this.LabelFrom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFrom.Location = new System.Drawing.Point(20, 192);
            this.LabelFrom.Name = "LabelFrom";
            this.LabelFrom.Size = new System.Drawing.Size(60, 26);
            this.LabelFrom.TabIndex = 12;
            this.LabelFrom.Text = "From";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTextBox.Location = new System.Drawing.Point(76, 189);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(600, 26);
            this.fromTextBox.TabIndex = 11;
            this.fromTextBox.Text = "From string";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(548, 53);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(128, 24);
            this.browseButton.TabIndex = 10;
            this.browseButton.Text = "Browse";
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceTextBox.Location = new System.Drawing.Point(12, 21);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(664, 26);
            this.sourceTextBox.TabIndex = 9;
            this.sourceTextBox.Text = "Filename source";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 324);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.LabelFrom);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.sourceTextBox);
            this.Name = "Form1";
            this.Text = "Oef 18.5 Zoek en vervang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button convertButton;
        internal System.Windows.Forms.SaveFileDialog SaveFileDialog1;
        internal System.Windows.Forms.TextBox destinationTextBox;
        internal System.Windows.Forms.Label LabelTo;
        internal System.Windows.Forms.Button saveButton;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.TextBox toTextBox;
        internal System.Windows.Forms.Label LabelFrom;
        internal System.Windows.Forms.TextBox fromTextBox;
        internal System.Windows.Forms.Button browseButton;
        internal System.Windows.Forms.TextBox sourceTextBox;
    }
}

