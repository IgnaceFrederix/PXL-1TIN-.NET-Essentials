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

namespace ConvertingBetweenNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 33;
            double d = 3.9;
            double d1;
            d1 = i;             // d1 wordt 33.0
            MessageBox.Show(Convert.ToString(d1));

            i = (int)d;         // i wordt 3
            MessageBox.Show(Convert.ToString(i));

            i = 33;
            d1 = Convert.ToDouble(i);     //d1 wordt 33.0
            MessageBox.Show(Convert.ToString(d1));

            i = Convert.ToInt32(d);       //i wordt 4
            MessageBox.Show(Convert.ToString(i));
        }
    }
}
