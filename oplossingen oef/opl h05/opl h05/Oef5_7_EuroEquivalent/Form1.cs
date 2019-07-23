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

namespace Oef5_7_EuroEquivalent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double euro = EuroEquivalent(Convert.ToDouble(dollarsTextBox.Text));
            eurosTextBox.Text = Convert.ToString(euro);
        }

        private double EuroEquivalent(double dollars)
        {
            return 0.7670 * dollars; // koers op 22.12.2011
        }
    }
}
