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

namespace Oef5_16_TijdsverschilInSec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verschilButton_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, g, verschil;
            Invoer3a(out a, out b, out c);
            Invoer3b(out d, out f, out g);
            verschil = TijdsverschilInSec(a, b, c, d, f, g);
            MessageBox.Show("Het verschil in seconden is: " + verschil);
        }

        private int TijdsverschilInSec(int u1, int m1, int s1,
                                       int u2, int m2, int s2)
        {
            int sec1 = TijdInSec(u1, m1, s1);
            int sec2 = TijdInSec(u2, m2, s2);
            return sec1 - sec2;
        }

        private void Invoer3a(out int a, out int b, out int c)
        {
            a = Convert.ToInt32(aTextBox.Text);
            b = Convert.ToInt32(bTextBox.Text);
            c = Convert.ToInt32(cTextBox.Text);
        }

        private void Invoer3b(out int d, out int e, out int f)
        {
            d = Convert.ToInt32(dTextBox.Text);
            e = Convert.ToInt32(eTextBox.Text);
            f = Convert.ToInt32(fTextBox.Text);
        }

        private int TijdInSec(int uren, int minuten, int seconden)
        {
            return uren * 3600 + minuten * 60 + seconden;
        }
    }
}
