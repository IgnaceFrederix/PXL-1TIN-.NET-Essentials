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

namespace Arithmetic_Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int n = 3;
            double d;
            i = n + 3;      // i krijgt de waarde 6
            MessageBox.Show("i = " + i);
            i = n * 4;      // i krijgt de waarde 12
            MessageBox.Show("i = " + i);
            i = 7 + 2 * 4;  // i krijgt de waarde 15
            MessageBox.Show("i = " + i);
            n = n * (n + 2) * 4; // n krijgt de waarde 60
            MessageBox.Show("n = " + n);
            d = 3.5 / 2;  // d krijgt de waarde 1.75
            MessageBox.Show("d = " + d);
            n = 7 / 4;  //n krijgt de waarde 1
            MessageBox.Show("n = " + n);
        }
    }
}
