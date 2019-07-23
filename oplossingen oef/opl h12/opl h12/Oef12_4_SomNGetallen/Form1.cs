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

namespace Oef12_4_SomNGetallen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            formuleLabel.Text = string.Empty;
            lusLabel.Text = string.Empty;
        }

        private void berekenButton_Click(System.Object sender, System.EventArgs e)
        {
            int n = Convert.ToInt32(nTextBox.Text);

            //gebruik formule
            formuleLabel.Text = Convert.ToString(n * (n + 1) / 2);

            //met lus
            int som = 0;
            for (int index = 1; index <= n; index++)
            {
                som = som + index;
            }
            lusLabel.Text = Convert.ToString(som);
        }
    }
}
