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

namespace TestVraag7_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Scroll += CheckValues;
            trackBar2.Scroll += CheckValues;
            trackBar3.Scroll += CheckValues;
        }

        private void CheckValues(object sender, EventArgs e)
        {
            int a = trackBar1.Value;
            int b = trackBar2.Value;
            int c = trackBar3.Value;
            int largest = a;

            if (b > largest)
            {
                largest = b;
            }

            if (c > largest)
            {
                largest = c;
            }

            messageLabel.Text = "largest value is " + largest;
        }
    }
}
