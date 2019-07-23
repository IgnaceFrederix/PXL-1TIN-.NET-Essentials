//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//-----------------------------------------------------------------------------
// Programmeren in C#
// Oefeningen en voorbeelden
// Auteur: Kris Hermans
//-----------------------------------------------------------------------------
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestVraag4_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("5" + "5" + 5 + 5);
            MessageBox.Show("5" + "5" + (5 + 5));
        }
    }
}
