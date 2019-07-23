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

namespace Testvragen
{
    public partial class Form1 : Form
    {
        private int largest;

        public Form1()
        {
            InitializeComponent();
        }

        private void largestButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(inputTextBox.Text);
            if (number > largest)
            {
                largest = number;
            }
            resultLabel.Text = "Largest so far is " + largest;
        }

        private double CalcPremium(double age, string gender)
        {
            double premium = 0;

            if (gender == "female")
            {
                if ((age >= 18) && (age <= 30))
                {
                    premium = 5.0;
                }
                else
                {
                    if (age >= 31)
                    {
                        premium = 3.5;
                    }
                    else
                    {
                        premium = 0;
                    }
                }
            }
            else if (gender == "male")
            {
                if ((age >= 18) && (age <= 35))
                {
                    premium = 6.0;
                }
                else
                {
                    if (age >= 36)
                    {
                        premium = 5.5;
                    }
                    else
                    {
                        premium = 0;
                    }
                }
            }
            else
            {
                premium = 0;
            }
            return premium;
        }
    }
}
