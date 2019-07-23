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

namespace Oef4_2_OmtrOppVol_Bol
{
    // Dit is de oplossing van gedeelte b)
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double opp, volume, omtrek;
            double straal = Convert.ToDouble(straalTextbox.Text);

            omtrek = 2 * straal * Math.PI;
            opp = straal * straal * Math.PI;
            volume = 4.0 / 3.0 * Math.Pow(straal, 3) * Math.PI;

            omtrekLabel.Text = String.Format("{0:0.00}", omtrek);
            oppLabel.Text = String.Format("{0:0.00}", opp);
            volumeLabel.Text = String.Format("{0:0.00}", volume);
        }
    }
}
