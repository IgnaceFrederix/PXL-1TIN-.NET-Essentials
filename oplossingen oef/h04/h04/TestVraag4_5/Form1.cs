//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------
// Programmeren in C#
// Oefeningen en voorbeelden
// Auteur: Kris Hermans
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestVraag4_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            a = 7 / 3;
            b = a * 4;
            c = (a + 1) / 2;
            d = c / 3;

            string message = String.Format("{0} {1} {2} {3}", a, b, c, d);
            MessageBox.Show(message);
        }
    }
}
