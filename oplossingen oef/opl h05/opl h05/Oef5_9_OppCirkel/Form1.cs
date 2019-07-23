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

namespace Oef5_9_OppCirkel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            double area = OppCirkel(Convert.ToDouble(straalTextBox.Text));
            MessageBox.Show(String.Format("De oppervlakte bedraagt {0:0.00}", area));
        }

        private double OppCirkel(double straal)
        {
            return Math.PI * straal * straal;
        }
    }
}
