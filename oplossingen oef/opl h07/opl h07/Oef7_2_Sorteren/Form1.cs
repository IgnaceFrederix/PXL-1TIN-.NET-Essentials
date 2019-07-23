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

namespace Oef7_2_Sorteren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            getal1TrackBar.Minimum = 0;
            getal1TrackBar.Maximum = 10;
            getal2TrackBar.Minimum = 0;
            getal2TrackBar.Maximum = 10;
            getal3TrackBar.Minimum = 0;
            getal3TrackBar.Maximum = 10;
            getal1Label.Text = "0";
            getal2Label.Text = "0";
            getal3Label.Text = "0";
        }

        private void sorteerButton_Click(object sender, System.EventArgs e)
        {
            int getal1;
            int getal2;
            int getal3;
            
            getal1 = getal1TrackBar.Value;
            getal2 = getal2TrackBar.Value;
            getal3 = getal3TrackBar.Value;
            if ((getal1 > getal2))
            {
                Swap(ref getal1, ref getal2);
            }
            if ((getal2 > getal3))
            {
                Swap(ref getal2, ref getal3);
            }
            if ((getal1 > getal2))
            {
                Swap(ref getal1, ref getal2);
            }
            resultaatLabel.Text = String.Format("Klein: {0}, Groter: {1}, Grootst: {2}",
                                                getal1, getal2, getal3);
        }

        private void Swap(ref int a, ref int b)
        {
            int aCopy;
            aCopy = a;
            a = b;
            b = aCopy;
        }

        private void getal1TrackBar_Scroll(object sender, System.EventArgs e)
        {
            getal1Label.Text = Convert.ToString(getal1TrackBar.Value);
        }

        private void getal2TrackBar_Scroll(object sender, System.EventArgs e)
        {
            getal2Label.Text = Convert.ToString(getal2TrackBar.Value);
        }

        private void getal3TrackBar_Scroll(object sender, System.EventArgs e)
        {
            getal3Label.Text = Convert.ToString(getal3TrackBar.Value);
        }
    }
}
