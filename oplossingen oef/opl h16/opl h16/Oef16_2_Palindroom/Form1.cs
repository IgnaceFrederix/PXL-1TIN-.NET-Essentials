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

namespace Oef16_2_Palindroom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void controleerButton_Click(object sender, EventArgs e)
        {
            string woord = string.Empty;
            int n = 0;
            int lengte = 0;
            lengte = woordTextBox.Text.Length;
            for (n = lengte; n >= 1; n -= 1)
            {
                woord = woord + woordTextBox.Text.Substring(n - 1, 1);
            }

            if (woordTextBox.Text == woord)
            {
                MessageBox.Show("Het woord '" + woordTextBox.Text + "' is een palindroon.");
            }
            else
            {
                MessageBox.Show("Het woord '" + woordTextBox.Text + "' geen palindroon.");
            }
        }
    }
}
