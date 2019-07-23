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

namespace Oef7_12_TernaireOperator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonBereken_Click(object sender, EventArgs e)
        {
            int leeftijd = Convert.ToInt32(TextBoxLeeftijd.Text);
            string msg = leeftijd < 5 | leeftijd >= 55 ? "gratis" : (leeftijd <= 12 ? "Halve prijs" : "Vol tarief");
            MessageBox.Show(msg);
        }
    }
}
