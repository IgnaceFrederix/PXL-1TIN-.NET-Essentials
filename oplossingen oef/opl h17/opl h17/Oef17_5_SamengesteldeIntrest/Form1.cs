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

namespace Oef17_5_SamengesteldeIntrest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(System.Object sender, System.EventArgs e)
        {
            double b = 0;
            double r = 0;
            int n = 0;
            double eind = 0;

            try
            {
                b = double.Parse(beginSaldoTextBox.Text);
                r = double.Parse(renteTextBox.Text);
                n = int.Parse(looptijdTextBox.Text);

                eind = b * (1 + r / 100) * n;

                eindSaldoLabel.Text = String.Format("{0:0.00}", eind);

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Gelieve 3 getallen in te geven, looptijd moet een geheel getal zijn");
            }

        }
    }
}
