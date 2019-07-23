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

namespace Oef12_11_Renterekenmachine
{
    public partial class Form1 : Form
    {
        private int year = 1;
        private int oldAmount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double rate;
            int newAmount;
            int euros;
            int cents;

            if (year == 1)
            {
                oldAmount = Convert.ToInt32(TextBox1.Text);
            }
            
            rate = Convert.ToDouble(TextBox2.Text);

            newAmount = oldAmount + Convert.ToInt32(oldAmount * (rate / 100));
            euros = (int)newAmount;
            cents = 100 * (newAmount - euros);

            TextBox3.AppendText(String.Format("After {0} years the money has become {1} euros and {2} eurocents\r\n\r\n",
                                               year, euros, cents));

            oldAmount = newAmount;
            year = year + 1;
        }
    }
}
