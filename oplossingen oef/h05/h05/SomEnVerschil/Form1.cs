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

namespace SomEnVerschil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            int g1, g2;
            int s, v;

            g1 = Convert.ToInt32(getal1TextBox.Text);
            g2 = Convert.ToInt32(getal2TextBox.Text);

            //s = Som(g1, g2);
            //v = Verschil(g1, g2);

            SomEnVerschil(g1, g2, out s, out v);
            somLabel.Text = Convert.ToString(s);
            verschilLabel.Text = Convert.ToString(v);
        }

        private int Som(int getal1, int getal2)
        {
            return getal1 + getal2;
        }

        private int Verschil(int getal1, int getal2)
        {
            return getal1 - getal2;
        }

        private void SomEnVerschil(int getal1, int getal2, out int som, out int verschil)
        {
            som = getal1 + getal2;
            verschil = getal1 - getal2;
        }

        private void ShowSum(Label display, int a, int b)
        {
            display.Text = Convert.ToString(a + b);
        }
    }
}
