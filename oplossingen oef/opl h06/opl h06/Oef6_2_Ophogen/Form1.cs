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

namespace Oef6_2_Ophogen
{
    public partial class Form1 : Form
    {
        private int getal = 1;

        public Form1()
        {
            InitializeComponent();

            waardeLabel.Text = Convert.ToString(getal);
        }

        private void verhoogButton_Click(object sender, EventArgs e)
        {
            getal = getal + 1;
            waardeLabel.Text = Convert.ToString(getal);
        }
    }
}
