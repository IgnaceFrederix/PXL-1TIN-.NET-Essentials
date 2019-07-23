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

namespace EurosAndCentsFormatted
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cents;
            cents = Convert.ToInt32(textBox1.Text);

            int euros = cents / 100;
            cents = cents % 100;

            //resultTextBox.Text = String.Format("{0} euros and {1} cents",
            //                                   euros, cents); 
            //resultTextBox.Text = String.Format("{0,15} euros and {1,-15} cents", euros, cents);

            cents = Convert.ToInt32(textBox1.Text);
            double eurosCurrency = (double)cents / 100;
            //resultTextBox.Text = String.Format("{0:c}", eurosCurrency);
            //resultTextBox.Text = String.Format("{0:d}", eurosCurrency);
            resultTextBox.Text = String.Format("{0:0.00}", 12.345);

        }
    }
}
