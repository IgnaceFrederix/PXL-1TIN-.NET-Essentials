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

namespace Oef12_8_Opp_Driehoek
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Hoofdstuk 12, oefening 8: de oppervlakte van een driehoek
        /// </summary>
        public Form1()
        {
            InitializeComponent();
             oppLabel.Text = "";
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(aTextBox.Text);
            int b = Convert.ToInt32(bTextBoxtxt.Text);
            int c = Convert.ToInt32(cTextBox.Text);
            int m = Max(a, b, c);   

        // Test driehoek: de grootste zijde moet kleiner zijn dan de som van de twee andere
        if (m == a && m >= b + c)
        {
            MessageBox.Show("Deze zijden kunnen nooit een driehoek vormen", "driehoek", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (m == b && m >= a + c)
        {
            MessageBox.Show("Deze zijden kunnen nooit een driehoek vormen", "driehoek", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        if (m == c && m >= b + a) 
        {
            MessageBox.Show("Deze zijden kunnen nooit een driehoek vormen", "driehoek", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        double s = (a + b + c) / 2;
        double opp = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        oppLabel.Text = String.Format("{0:F3}", opp);
        }

        private int Max(int a, int b, int c )
        {
            int m = a;
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