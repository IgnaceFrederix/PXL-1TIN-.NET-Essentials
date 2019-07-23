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

namespace Euros_and_Cents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int originalCents, wholeEuros, centsLeft;
            originalCents = Convert.ToInt32(inputTextBox.Text);
            EurosAndCents(originalCents, out wholeEuros, out centsLeft);
            eurosLabel.Text = Convert.ToString(wholeEuros);
            centsLabel.Text = Convert.ToString(centsLeft);
        }

        private void EurosAndCents(int totalCents,
                                   out int euros,
                                   out int centsLeft)
        {
            // int temp = euros; compile error!
            euros = totalCents / 100;
            centsLeft = totalCents % 100;
        }

        // voor testvraag 5.9
        private void EurosAndCents2(int a,
                                    out int b,
                                    out int c)
        {
            b = a / 100;
            c = a % 100;
        }
    }
}
