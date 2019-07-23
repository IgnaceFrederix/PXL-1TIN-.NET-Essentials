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

namespace Interest_Calculation
{
    public partial class Form1 : Form
    {

        private int year = 1;
        private double oldAmount;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void yearButton_Click(object sender, EventArgs e)
        {
            double rate, newAmount;
            int euros, cents;

            if (year == 1)
            {
                oldAmount = Convert.ToDouble(initialAmountTextBox.Text);
            }

            rate  = Convert.ToDouble(rateTextBox.Text);

            newAmount = oldAmount + (oldAmount * rate / 100);

            euros = (int)newAmount;
            cents = (int)Math.Round(100 * (newAmount - euros));
            String line = String.Format("After {0} years the money has become " +
                                        "{1} euros and {2} eurocents.",
                                        year, euros, cents);
            resultTextBox.AppendText(line);
            resultTextBox.AppendText(Environment.NewLine);
            resultTextBox.AppendText(Environment.NewLine);

            oldAmount = newAmount;
            year += 1;
        }
    }
}
