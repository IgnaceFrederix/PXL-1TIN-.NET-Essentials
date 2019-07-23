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

namespace Oef5_10_TijdInSec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aantalButton_Click(object sender, EventArgs e)
        {
            int aantalSec = TijdInSec(Convert.ToInt32(urenTextBox.Text),
                                      Convert.ToInt32(minutenTextBox.Text),
                                      Convert.ToInt32(secondenTextBox.Text));
            MessageBox.Show("Aantal seconden: " + aantalSec);
        }

        private int TijdInSec(int uren, int minuten, int seconden)
        {
            return (uren * 3600 + minuten * 60 + seconden);
        }
    }
}
