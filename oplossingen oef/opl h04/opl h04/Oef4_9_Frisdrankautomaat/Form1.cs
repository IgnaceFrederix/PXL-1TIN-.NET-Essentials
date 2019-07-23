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

namespace Oef4_9_Frisdrankautomaat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amountGiven = 100;
            int itemCost = 45;
            int amount100, amount50, amount20, amount10, amount5, amount2, amount1;
            int change;
            change = amountGiven - itemCost;

            amount100 = change / 100;
            change = change % 100;

            amount50 = change / 50;
            change = change % 50;

            amount20 = change / 20;
            change = change % 20;

            amount10 = change / 10;
            change = change % 10;

            amount5 = change / 5;
            change = change % 5;

            amount2 = change / 2;
            change = change % 2;

            amount1 = change / 1;
            change = change % 1;

            // Twee mogelijkheden om strings met getallen te tonen
            // String.Format is handiger bij meerdere getallen per string of complexere opmaak (doubles)
            MessageBox.Show(String.Format("Number of 1 euro coins is {0:d}", amount100));
            MessageBox.Show("Number of 50 cent coins is " + Convert.ToString(amount50));
            MessageBox.Show("Number of 20 cent coins is " + Convert.ToString(amount20));
            MessageBox.Show("Number of 10 cent coins is " + Convert.ToString(amount10));
            MessageBox.Show("Number of 5 cent coins is " + Convert.ToString(amount5));
            MessageBox.Show("Number of 2 cent coins is " + Convert.ToString(amount2));
            MessageBox.Show("Number of 1 cent coins is " + Convert.ToString(amount1));
        }
    }
}
