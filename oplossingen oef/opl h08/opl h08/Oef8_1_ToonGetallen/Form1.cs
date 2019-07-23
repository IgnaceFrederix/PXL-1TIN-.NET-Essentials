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

namespace Oef8_1_ToonGetallen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toonButton_Click(object sender, System.EventArgs e)
        {
            int i;
            for (i = 1; i <= 10; i++)
            {
                machtenTextBox.AppendText(String.Format("{0}\t{1}\n",i, Math.Pow(i,3)));
            }
        }
    }
}
