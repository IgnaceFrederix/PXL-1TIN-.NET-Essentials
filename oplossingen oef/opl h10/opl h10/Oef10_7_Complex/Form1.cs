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

namespace Oef10_7_Complex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(1.0, 2.0);
            Complex c2 = new Complex(-1.0, 4.0);

            Complex sum = c1.Sum(c2);
            Complex product = c1.Product(c2);

            String msg = String.Format("Complex c1: {0}\r\nComplex 2: {1}\r\n" +
                                       "Som: {2}\r\nVerschil: {3}",
                                       c1, c2, sum, product);
            MessageBox.Show(msg);
        }
    }
}
