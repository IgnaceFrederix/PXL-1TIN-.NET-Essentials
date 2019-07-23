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

namespace Oef18_1_NaamAdres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opslaanButton_Click(System.Object sender, System.EventArgs e)
        {
            StreamWriter outputStream = File.CreateText("adres.txt");

            outputStream.WriteLine(adresTextBox.Text);

            outputStream.Close();
        }

        private void openenButton_Click(System.Object sender, System.EventArgs e)
        {
            StreamReader inputStream = File.OpenText("adres.txt");
            string line = null;

            line = inputStream.ReadLine();
            while (line != null)
            {
                adresTextBox.AppendText(line + Environment.NewLine);
                line = inputStream.ReadLine();
            }

            inputStream.Close();
        }
    }
}
