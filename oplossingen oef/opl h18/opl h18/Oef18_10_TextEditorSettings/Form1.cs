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
    public partial class Form1 : Form
    {
        private string currentFile = "";
        private string initialDir;
        
        public Form1()
        {
            InitializeComponent();

            initialDir = Environment.GetFolderPath(
                            Environment.SpecialFolder.MyDocuments);
            ReadSettings();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader inputStream;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = initialDir;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = dialog.FileName;
                inputStream = File.OpenText(currentFile);
                mainTextBox.Text = inputStream.ReadToEnd();
                inputStream.Close();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter outputStream;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = initialDir;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = dialog.FileName;
                outputStream = File.CreateText(currentFile);
                outputStream.Write(mainTextBox.Text);
                outputStream.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFile == "")
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.InitialDirectory = initialDir;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    currentFile = dialog.FileName;
                }
            }
            StreamWriter outputStream = File.CreateText(currentFile);
            outputStream.Write(mainTextBox.Text);
            outputStream.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm(mainTextBox);
            form.ShowDialog();
        }

        private void ReadSettings()
        {
            string settingsfile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                               "PearsonTextEditor",
                                               "Settings.txt");
            if (File.Exists(settingsfile))
            {
                StreamReader reader = new StreamReader(settingsfile);
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (line.StartsWith("Font Name ="))
                    {
                        int index = line.IndexOf('=');
                        string fontname = line.Substring(index + 1).Trim();
                        mainTextBox.Font = new Font(fontname, mainTextBox.Font.Size);
                    }
                    else if (line.StartsWith("Fore Color ="))
                    {
                        int index = line.IndexOf('=');
                        mainTextBox.ForeColor = CreateColor(line.Substring(index + 1).Trim());
                    }
                    else if (line.StartsWith("Back Color ="))
                    {
                        int index = line.IndexOf('=');
                        mainTextBox.BackColor = CreateColor(line.Substring(index + 1).Trim());
                    }
                    line = reader.ReadLine();
                }
                reader.Close();
            }

        }
        private Color CreateColor(String rgb)
        {
            string[] parts = rgb.Split(new char[]{','});
            int r = Int32.Parse(parts[0].Trim());
            int g = Int32.Parse(parts[1].Trim());
            int b = Int32.Parse(parts[2].Trim());

            return Color.FromArgb(255, r, g, b);
        }

        private void mainTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
