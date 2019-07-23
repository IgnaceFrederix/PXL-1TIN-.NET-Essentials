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

namespace Oef5_18_Ophoging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ophogenButton_Click(object sender, EventArgs e)
        {
            int getal = Convert.ToInt32(getalTextBox.Text);
            Ophoging(ref getal);
            MessageBox.Show("Getal na ophoging: " + getal);
        }

        private void Ophoging(ref int g)
        {
            g = g + 1;
        }
    }
}
