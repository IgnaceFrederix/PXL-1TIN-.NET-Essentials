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

namespace Oef5_11_OppCilinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            double area = OppCilinder(Convert.ToDouble(straalTextBox.Text),
                                      Convert.ToDouble(hoogteTextBox.Text));
            MessageBox.Show(String.Format("De oppervlakte van de cilinder bedraagt {0:0.00}", area));
        }

        private double OppCirkel(double straal)
        {
            return Math.PI * straal * straal;
        }

        private double OppCilinder(double straal, double hoogte)
        {
            return OppCirkel(straal) * 2 + 2 * Math.PI * straal * hoogte;
        }

    }
}
