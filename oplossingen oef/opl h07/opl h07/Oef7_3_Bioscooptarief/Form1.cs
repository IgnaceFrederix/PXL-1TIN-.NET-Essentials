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

namespace Oef7_3_Bioscooptarief
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            int leeftijd = Convert.ToInt32(leeftijdTextBox.Text);
            if (leeftijd < 5)
            {
                 tariefLabel.Text = "Gratis";
            }
            else if (leeftijd <= 12)
            {
                tariefLabel.Text = "Halve prijs";
            }
            else if (leeftijd <= 54)
            {
                tariefLabel.Text = "Vol tarief";
            }
            else
            {
                tariefLabel.Text = "Gratis";
            }
        }
    }
}
