//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Oef18_10_TextEditorSettings
{
    public partial class SettingsForm : Form
    {
        private TextBox mainTextBox;

        public SettingsForm(TextBox mainTextBox)
        {
            InitializeComponent();
            this.mainTextBox = mainTextBox;
            ReadFont(mainTextBox);
            colorLabel.BackColor = mainTextBox.BackColor;
        }

        private void fontButton_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            dialog.ShowColor = true;
            dialog.Font = mainTextBox.Font;
            dialog.Color = mainTextBox.ForeColor;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mainTextBox.ForeColor = dialog.Color;
                mainTextBox.Font = dialog.Font;
                ReadFont(mainTextBox);
            }
        }

        private void ReadFont(TextBox tb)
        {
            fontTextBox.Text = tb.Font.Name + ", " + tb.ForeColor.ToString();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = mainTextBox.BackColor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mainTextBox.BackColor = dialog.Color;
                colorLabel.BackColor = dialog.Color;
            }
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string settingsdir = Path.Combine(appdata, "PearsonTextEditor");
            if (!Directory.Exists(settingsdir))
            {
                Directory.CreateDirectory(settingsdir);
            }

            string settingsfile = Path.Combine(settingsdir, "Settings.txt");
            StreamWriter writer = new StreamWriter(settingsfile);
            writer.WriteLine("Font Name = " + mainTextBox.Font.Name);
            writer.WriteLine(String.Format("Fore Color = {0},{1},{2}",
                                           mainTextBox.ForeColor.R,
                                           mainTextBox.ForeColor.G,
                                           mainTextBox.ForeColor.B));
            writer.WriteLine(String.Format("Back Color = {0},{1},{2}",
                                           mainTextBox.BackColor.R,
                                           mainTextBox.BackColor.G,
                                           mainTextBox.BackColor.B));
            writer.Close();
        }
    }
}
