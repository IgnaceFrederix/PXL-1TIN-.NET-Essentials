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

namespace Testvraag18_1_Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "pattern.txt";
            StreamWriter streamOut = File.CreateText(fileName);
            for (int lines = 1; lines <= 10; lines++)
            {
                for (int stars = 1; stars <= lines; stars++)
                {
                    streamOut.Write("*");
                }
                streamOut.WriteLine();
            }
            streamOut.Close();
        }
    }
}
