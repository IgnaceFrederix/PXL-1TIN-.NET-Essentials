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

namespace Oef5_20_TijdInSec_DefaultParams
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
            int min = Convert.ToInt32(minutenTextBox.Text);
            int sec = Convert.ToInt32(secondenTextBox.Text);

            int aantalSec;

            //if en else in feite nog niet gezien
            if (uren > 0)
            {
                aantalSec = TijdInSec(uren, min, sec);
            }
            else
            {
                aantalSec = TijdInSec(minuten: min, seconden: sec);
            }
            
            MessageBox.Show("Aantal seconden: " + aantalSec);
        }

        private int TijdInSec(int uren = 0, int minuten = 0, int seconden = 0)
        {
            return (uren * 3600 + minuten * 60 + seconden);
        }
    }
}
