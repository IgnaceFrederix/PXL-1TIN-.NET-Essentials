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

namespace File_Input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            string sourcepath = Environment.GetFolderPath(
                                   Environment.SpecialFolder.MyDocuments);
            string myfile = Path.Combine(sourcepath, "myfile.txt");
            StreamReader inputStream = File.OpenText(myfile);
            string line = inputStream.ReadLine();
            while (line != null)
            {
                fileTextBox.AppendText(line);
                fileTextBox.AppendText(Environment.NewLine);
                line = inputStream.ReadLine();
            }
            inputStream.Close();
        }
    }
}
