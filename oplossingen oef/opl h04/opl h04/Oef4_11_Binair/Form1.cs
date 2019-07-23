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

namespace Oef4_11_Binair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            string result = String.Empty;
            int amount = Convert.ToInt32(numberTextBox.Text);
            int division;

            division = amount / 128;
            amount = amount % 128;
            result = result + division;

            division = amount / 64;
            amount = amount % 64;
            result = result + division;

            division = amount / 32;
            amount = amount % 32;
            result = result + division;

            division = amount / 16;
            amount = amount % 16;
            result = result + division;

            division = amount / 8;
            amount = amount % 8;
            result = result + division;

            division = amount / 4;
            amount = amount % 4;
            result = result + division;

            division = amount / 2;
            amount = amount % 2;
            result = result + division + amount;

            binLabel.Text = result;
        }
    }
}
