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

namespace Oef8_9_SomReeks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            double noemer = 1;
            double som = 1;
            termenTextBox.Clear();
            termenTextBox.AppendText("1");
            while (noemer <= 10000)
            {
                noemer++;
                if ((noemer % 2) == 0)
                {
                    som = som - (1 / noemer);
                    termenTextBox.AppendText(String.Format(" -1/{0}",noemer));
                }
                else
                {
                    som = som + (1 / noemer);
                    termenTextBox.AppendText(String.Format(" +1/{0}", noemer));
                }
            }
            termenTextBox.AppendText(String.Format(" = {0}",som));
        }
    }
}
