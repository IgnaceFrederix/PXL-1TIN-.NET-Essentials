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

namespace Grains_of_rice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int square = 1;
            int rice = 1;
            int total = 1;
            resultTextBox.Clear();
            DisplayCounts(square, rice);

            while ((total < 10000) && (square < 64))
            {
                square = square + 1;
                rice = rice * 2;
                DisplayCounts(square, rice);
                total = total + rice;
            }

            resultTextBox.AppendText(Environment.NewLine + 
                                     "Total is " + total +
                                     Environment.NewLine + 
                                     "on " + square + " squares");
        }

        private void DisplayCounts(int square, int rice)
        {
            string line = String.Format("On square {0} are {1} grains",
                                        square, rice) + Environment.NewLine;
            resultTextBox.AppendText(line);
        }
    }
}
