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

namespace Oef12_1_KostenTelefoonGesprek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            prijsLabel.Text = string.Empty;
        }

        private void berekenButton_Click(System.Object sender, System.EventArgs e)
        {
            double minuten = Convert.ToInt32(urenTextBox.Text) * 60 +
                             Convert.ToInt32(minutenTextBox.Text) +
                             Convert.ToDouble(secondenTextBox.Text) / 60;
            double prijs = minuten * 10;

            prijsLabel.Text = String.Format("{0:0.00} eurocenten", prijs);
        }
    }
}
