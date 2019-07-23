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

namespace Oef7_14_Autoverzekering
{
    /// <summary>
    /// Hoofdstuk 7, oefening 14: premie autoverzekering
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string lijn = "uw geslacht: ";
            if (manRadioButton.Checked)
            {
                lijn = lijn + "man";
            }
            else
            {
                lijn = lijn + "vrouw";
            }
            MessageBox.Show(lijn);
        }
    }
}
