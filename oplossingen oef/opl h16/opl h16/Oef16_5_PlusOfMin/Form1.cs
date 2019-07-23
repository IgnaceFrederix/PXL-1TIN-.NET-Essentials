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

namespace Oef16_5_PlusOfMin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(System.Object sender, System.EventArgs e)
        {
            string term = invoerTextBox.Text;
            int spatie = term.IndexOf(" ");

            int g1 = Convert.ToInt32(term.Substring(0, spatie));
            string op = term.Substring(spatie + 1, 1);
            int g2 = Convert.ToInt32(term.Substring(spatie + 3));

            if (op == "+")
            {
                resultLabel.Text = Convert.ToString(g1 + g2);
            }
            else
            {
                resultLabel.Text = Convert.ToString(g1 - g2);
            }

        }
    }
}
