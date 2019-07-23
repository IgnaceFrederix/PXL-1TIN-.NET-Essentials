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

namespace Oef12_13_NumeriekeIntegratie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtAantal.Text = String.Empty;
            txtResult.Text = String.Empty;
        }
    
        private void btnBereken_Click(object sender, System.EventArgs e)
        {    
            int n = Convert.ToInt32(txtAantal.Text);
            double opp = 0;
            //  alle 2y componenten
            for (int index = 1; index <= (n - 1); index++)
            {
                opp = opp + 2 * Fun(Math.PI * index / n);
            }
            // y0 en yn
            opp = opp + Fun(0) + Fun(Math.PI);
            // vermenigvuldigen met d en delen door 2
            opp = opp * Math.PI / n / 2;
            txtResult.AppendText(String.Format("Voor d = {0} bedraagt de opp tussen 0 en PI van de sinusfunctie: {1:0.0000}\r\n", n, opp));
        }

        private double Fun(double x)
        {
            return Math.Sin(x);
        }
    }
}
