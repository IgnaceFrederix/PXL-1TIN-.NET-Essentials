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

namespace Directory_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            filesTextBox.Clear();
            foldersTextBox.Clear();
            // Display all file names
            string[] files = Directory.GetFiles(folderTextBox.Text);
            foreach (string file in files)
            {
                filesTextBox.AppendText(file);
                filesTextBox.AppendText(Environment.NewLine);
            }
            // Display all folder names
            string[] dirs = Directory.GetDirectories(folderTextBox.Text);
            foreach (string dir in dirs)
            {
                foldersTextBox.AppendText(dir);
                foldersTextBox.AppendText(Environment.NewLine);
            }

        }
    }
}
