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

namespace Oef4_5_Inkomstenbelasting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            double brutoInkomen = Convert.ToDouble(inkomenTextBox.Text);
            double belasting = brutoInkomen * 0.2;
            double nettoInkomen = brutoInkomen - belasting;

            belastingLabel.Text = String.Format("{0:0.00}",belasting);
            nettoLabel.Text = String.Format("{0:0.00}",nettoInkomen);
        }
    }
}
