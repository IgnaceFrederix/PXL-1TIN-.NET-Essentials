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

namespace Oef4_8_Weerstanden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toonButton_Click(object sender, EventArgs e)
        {
            double r1 = 4.7;
            double r2 = 6.8;
            double series = r1 + r2;
            double parallel = (r1 * r2) / (r1 + r2);
            MessageBox.Show(String.Format("serieweerstand is {0:0.00}", series));
            MessageBox.Show(String.Format("parallelweerstand is {0:0.00}", parallel));
        }
    }
}
