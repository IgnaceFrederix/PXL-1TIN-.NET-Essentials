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

namespace Oef4_3_Gemiddelde
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cijfer1 = 44;
            int cijfer2 = 51;
            // geheel getal met /-operator geeft afkapping van resultaat
            double gem = (cijfer1 + cijfer2) / 2; 

            string bericht = String.Format("Het gemiddelde van {0} en {1} is {2}", cijfer1, cijfer2, gem);
            MessageBox.Show(bericht);
        }
    }
}
