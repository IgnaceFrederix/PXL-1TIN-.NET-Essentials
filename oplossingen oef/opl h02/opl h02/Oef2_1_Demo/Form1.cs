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

namespace Oef2_1_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelA.Text = "Ja";
            labelB.Text = "Ja";
            labelC.Text = "Ja";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelA.Text = "Nee";
            labelB.Text = "Nee";
            labelC.Text = "Nee";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelA.Text = "A";
            labelB.Text = "B";
            labelC.Text = "C";
        }
    }
}
