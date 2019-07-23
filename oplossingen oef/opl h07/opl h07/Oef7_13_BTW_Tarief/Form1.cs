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

namespace Oef7_13_BTW_Tarief
{
    /// <summary>
    /// Hoofdstuk 7, oefening 13: BTW-tarief
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BerekenButton_Click(object sender, EventArgs e)
        {
            double btw;
            double netto = Convert.ToDouble(nettoTextBox.Text);

            if (tariefCheckBox.Checked) 
            {
                btw = netto * 0.06;
            }
            else
            {
                btw = netto * 0.21;
            }

            BTWLabel.Text = Convert.ToString(btw);
            totaalLabel.Text = Convert.ToString(btw + netto);
        }
    }
}
