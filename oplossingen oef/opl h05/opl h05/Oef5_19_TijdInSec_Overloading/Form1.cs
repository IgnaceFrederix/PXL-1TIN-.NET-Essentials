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

namespace Oef5_19_TijdInSec_Overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aantalButton_Click(object sender, EventArgs e)
        {
            int uren = Convert.ToInt32(urenTextBox.Text);
            int aantalSec;

            //if en else in feite nog niet gezien
            if (uren > 0)
            {
                aantalSec = TijdInSec(uren, Convert.ToInt32(minutenTextBox.Text),
                                            Convert.ToInt32(secondenTextBox.Text));
            }
            else
            {
                aantalSec = TijdInSec(Convert.ToInt32(minutenTextBox.Text),
                                      Convert.ToInt32(secondenTextBox.Text));
            }
            
            MessageBox.Show("Aantal seconden: " + aantalSec);
        }

        private int TijdInSec(int uren, int minuten, int seconden)
        {
            return (uren * 3600 + TijdInSec(minuten, seconden));
        }

        private int TijdInSec(int minuten, int seconden)
        {
            return (minuten * 60 + seconden);
        }
    }
}
