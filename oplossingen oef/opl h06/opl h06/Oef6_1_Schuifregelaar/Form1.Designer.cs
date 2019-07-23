namespace Oef6_1_Schuifregelaar
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
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.waardeTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.waardeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // maxLabel
            // 
            this.maxLabel.Location = new System.Drawing.Point(218, 164);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(40, 24);
            this.maxLabel.TabIndex = 26;
            // 
            // minLabel
            // 
            this.minLabel.Location = new System.Drawing.Point(34, 172);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(40, 24);
            this.minLabel.TabIndex = 25;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(66, 52);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(152, 23);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "(Minimum 0 en maximum 10)";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(170, 20);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 24);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Max";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(50, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 24);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Min";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(146, 84);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTextBox.TabIndex = 19;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(26, 84);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTextBox.TabIndex = 18;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(98, 220);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 20;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // waardeTrackBar
            // 
            this.waardeTrackBar.Location = new System.Drawing.Point(26, 124);
            this.waardeTrackBar.Name = "waardeTrackBar";
            this.waardeTrackBar.Size = new System.Drawing.Size(216, 45);
            this.waardeTrackBar.TabIndex = 22;
            this.waardeTrackBar.Tag = "";
            this.waardeTrackBar.ValueChanged += new System.EventHandler(this.waardeTrackBar_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.waardeTrackBar);
            this.Name = "Form1";
            this.Text = "Oef 6.1 Schuifregelaar";
            ((System.ComponentModel.ISupportInitialize)(this.waardeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label maxLabel;
        internal System.Windows.Forms.Label minLabel;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox maxTextBox;
        internal System.Windows.Forms.TextBox minTextBox;
        internal System.Windows.Forms.Button startButton;
        internal System.Windows.Forms.TrackBar waardeTrackBar;
    }
}

