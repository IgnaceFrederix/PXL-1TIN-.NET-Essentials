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

namespace Oef16_3_TypeGetal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            double getal;

            if (Double.TryParse(getalTextBox.Text, out getal))
            {
                if (getalTextBox.Text.IndexOf(",") != -1)
                {
                    MessageBox.Show("Dit is een double");
                }
                else
                {
                    MessageBox.Show("Dit is een integer");
                }
            }
            else
            {
                MessageBox.Show("Geef een getal in");
            }
        }
    }
}
