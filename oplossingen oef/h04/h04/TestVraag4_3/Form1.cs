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

namespace TestVraag4_3
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
            d = -8;
            a = 1 * 2 + 3;
            b = 1 + 2 * 3;
            c = (1 + 2) * 3;
            c = a + b;
            d = -d;

            string bericht = String.Format("{0} {1} {2} {3}",a,b,c,d);
            MessageBox.Show(bericht);
        }
    }
}
