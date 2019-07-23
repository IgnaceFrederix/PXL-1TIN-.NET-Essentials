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

namespace Oef16_6_PlusMinReeks
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

            int result = g1;
            int spatie2 = term.IndexOf(" ", spatie + 3);

            do
            {
                string op = term.Substring(spatie + 1, 1);
                if (spatie2 == -1)
                {
                    g1 = Convert.ToInt32(term.Substring(spatie + 3));
                }
                else
                {
                    g1 = Convert.ToInt32(term.Substring(spatie + 3, spatie2 - spatie - 3));

                }

                if (op == "+")
                {
                    result = result + g1;
                }
                else
                {
                    result = result - g1;
                }

                spatie = spatie2;

                if (spatie != -1)
                {
                    spatie2 = term.IndexOf(" ", spatie + 3);
                }
            } while (!(spatie == -1));
            resultLabel.Text = Convert.ToString(result);
        }
    }
}
