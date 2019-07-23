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

namespace Oef12_6_Reeksontwikkeling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            berekeningLabel.Text = String.Empty;
            iteratiesLabel.Text = "0";
            eLabel.Text = String.Empty;
        }

        private void berekenButton_Click(object sender, System.EventArgs e)
        {
            int iteraties = 1;
            int x = int.Parse(xTextBox.Text);
            double nwk = Math.Pow(10, (int.Parse(nauwkTextBox.Text) - 1) * -1);
            //  we veronderstellen dat txtNauwk zeker >= 1 is
            double ex = 1;
            // berekende waarde
            double ex_ref = Math.Pow(Math.E, x);
            // correcte waarde
            while (Math.Abs((ex - ex_ref)) > nwk)
            {
                ex = ex + Math.Pow(x, iteraties) / Fac(iteraties);
                iteraties = (iteraties + 1);
            }
            string f = MaakFormatString(int.Parse(nauwkTextBox.Text));
            berekeningLabel.Text = String.Format("{0:"+f+"}", ex);
            eLabel.Text = String.Format("{0:" + f + "}", ex);
            iteratiesLabel.Text = iteraties.ToString();
        }

        private string MaakFormatString(int precision)
        {
            string s = "0.";
            for (int index = 1; (index <= precision); index++)
            {
                s = (s + "0");
            }
            return s;
        }

        // '' <summary>
        // '' Er moet hier een Double teruggegeven worden omdat de faculteiten in deze reeksontwikkeling zeer snel zeer groot worden.
        // '' </summary>
        // '' <param name="n"></param>
        // '' <returns></returns>
        // '' <remarks></remarks>
        private double Fac(int n)
        {
            double f = 1;
            if (n == 0)
            {
                return 1;
            }
            for (int index = 1; index <= n; index++)
            {
                f = (f * index);
            }
            return f;
        }
    }
}