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

namespace Oef8_5_SomGetallen
{
    public partial class Form1 : Form
    {
        private int n = 39;
        private int som = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void somButton_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i <= n; i++)
            {
                som = som + i;
            }
            Label2.Text = ("De som is " + som);
        }

        private void controleButton_Click(object sender, System.EventArgs e)
        {
            som = n * ((n + 1) / 2);
            Label3.Text = ("De som is " + som);
        }
    }
}
