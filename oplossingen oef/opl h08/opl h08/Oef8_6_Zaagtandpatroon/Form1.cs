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

namespace Oef8_6_Zaagtandpatroon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            patternTextBox.Clear();

            for (int teeth = 1; teeth <= 3; teeth++)
            {
                for (int row = 1; row <= 4; row++)
                {
                    for (int character = 1; character <= row; character++)
                    {
                        patternTextBox.AppendText("S");
                    }
                    patternTextBox.AppendText(Environment.NewLine);
                }
            } 
        }
    }
}
