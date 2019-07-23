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

namespace Oef17_3_OppDriehoek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(System.Object sender, System.EventArgs e)
        {
            try
            {
                BerekenOppervlakte();
            }
            catch (WrongLengthException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BerekenOppervlakte()
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double s = 0;
            double opp = 0;

            oppLabel.Text = "";

            a = Convert.ToDouble(aTextBox.Text);
            b = Convert.ToDouble(bTextBox.Text);
            c = Convert.ToDouble(cTextBox.Text);
            double m = Max(a, b, c);

            // Test driehoek: de grootste zijde moet kleiner zijn dan de som van de twee andere
            if (m == a && m >= b + c)
            {
                throw new WrongLengthException("deze zijden kunnen nooit een driehoek vormen");
            }
            if (m == b && m >= a + c)
            {
                throw new WrongLengthException("deze zijden kunnen nooit een driehoek vormen");
            }
            if (m == c && m >= b + a)
            {
                throw new WrongLengthException("deze zijden kunnen nooit een driehoek vormen");
            }

            s = (a + b + c) / 2;
            opp = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            oppLabel.Text = String.Format("De oppervlakte van de driehoek is {0:0.00}",opp);
        }

        private double Max(double a, double b, double c)
        {
            double m = a;
            if (b > m)
            {
                m = b;
            }
            if (c > m)
            {
                m = c;
            }
            return m;
        }
    }
}
