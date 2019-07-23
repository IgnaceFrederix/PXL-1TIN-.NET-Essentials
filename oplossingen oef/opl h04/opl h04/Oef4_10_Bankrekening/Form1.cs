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

namespace Oef4_10_Bankrekening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(beginTextBox.Text);
            int n = Convert.ToInt32(aantalTextBox.Text);
            double r = Convert.ToDouble(renteTextBox.Text);

            double eindsaldo = b * Math.Pow(1 + (r / 100),n);
            MessageBox.Show(String.Format("Het eindsaldo is {0:0.00}", eindsaldo));
        }
    }
}
