//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------
// Programmeren in C#
// Oefeningen en voorbeelden
// Auteur: Kris Hermans
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestVraag4_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, n;
            string s;
            string v = "3";
            m = Convert.ToInt32(v + v + "4");
            n = Convert.ToInt32(v + v) + 4;
            s = Convert.ToString(Convert.ToInt32(v)
                + Convert.ToInt32(v)) + "4";

            MessageBox.Show(String.Format("{0}, {1}, {2}", m, n, s));
        }
    }
}
