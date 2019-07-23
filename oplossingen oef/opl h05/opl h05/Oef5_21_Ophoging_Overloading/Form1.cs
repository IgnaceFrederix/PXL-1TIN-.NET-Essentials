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

namespace Oef5_21_Ophoging_Overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void intButton_Click(object sender, EventArgs e)
        {
            int getal = Convert.ToInt32(waardeTextBox.Text);
            Ophoging(ref getal);
            MessageBox.Show("Waarde na ophoging: " + getal);
        }

        private void doubleButton_Click(object sender, EventArgs e)
        {
            double getal = Convert.ToDouble(waardeTextBox.Text);
            Ophoging(ref getal);
            MessageBox.Show("Waarde na ophoging: " + getal);
        }

        private void stringButton_Click(object sender, EventArgs e)
        {
            string waarde = waardeTextBox.Text;
            Ophoging(ref waarde);
            MessageBox.Show("Waarde na ophoging: " + waarde);
        }


        private void Ophoging(ref int g)
        {
            g = g + 1;
        }

        private void Ophoging(ref double g)
        {
            g = g + 1;
        }

        private void Ophoging(ref string g)
        {
            g = g + " * "; // ster toevoegen om het effect zichtbaar te maken
        }
    }
}
