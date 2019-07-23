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

namespace File_Output
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputStream = File.CreateText(@"C:\myfile.txt");
            outputStream.WriteLine("This file will");
            outputStream.WriteLine("contain 3");
            outputStream.WriteLine("lines of text.");
            outputStream.Close();
        }

        private void myDocButton_Click(object sender, EventArgs e)
        {
            string destination = Environment.GetFolderPath(
                                    Environment.SpecialFolder.MyDocuments);
            statusLabel.Text = "Writing to: " + destination;

            string newFile = Path.Combine(destination, "myfile.txt");
            StreamWriter outputStream = File.CreateText(newFile);
            outputStream.WriteLine("This file will");
            outputStream.WriteLine("contain 3");
            outputStream.WriteLine("lines of text.");
            outputStream.Close();
        }

        private void writeAppButton_Click(object sender, EventArgs e)
        {
            string destination = Environment.GetFolderPath(
                                    Environment.SpecialFolder.ApplicationData);
            statusLabel.Text = "Writing to: " + destination;

            string newFile = Path.Combine(destination, "myfile.txt");
            StreamWriter outputStream = File.CreateText(newFile);
            outputStream.WriteLine("This file will");
            outputStream.WriteLine("contain 3");
            outputStream.WriteLine("lines of text.");
            outputStream.Close();
        }



    }
}
