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

namespace SinusReeks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            String line = String.Format("{0} en {1}", Sin(14), Math.Sin(14));
            MessageBox.Show(line);
        }

        private double Sin(double x)
        {
            double term, result;

            result = 0.0;
            term = x;
            int n = 1;
            while (Math.Abs(term) >= 0.0001)
            {
                result += term;
                term = -term * x * x / ((n + 1) * (n + 2));
                n += 2;
            }
            return result;
        }
    }
}
