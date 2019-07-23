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

namespace Divisions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // double divisions
            double d;
            //output("d = " + d); geeft compilerfout omdat d unassigned is
            d = 7.61 / 2.1;
            output("d = " + d);
            d = 10.6 / 2;
            output("d = " + d);

            // integer divisions
            int i;
            i = 10 / 5;
            output("i = " + i);
            i = 13 / 5;
            output("i = " + i);
            i = 33 / 44;
            output("i = " + i);

            d = 14.9 % 3.9;
            output("d = " + d);
        }

        private void output(string message)
        {
            MessageBox.Show(message);
        }
    }
}
