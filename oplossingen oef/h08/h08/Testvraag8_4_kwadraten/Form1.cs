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

namespace Testvraag8_4_kwadraten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kwadraatButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            for (int getal = 1; getal <= 5; getal++)
            {
                string lijn = String.Format("{0} {1}", getal, getal * getal);
                resultTextBox.AppendText(lijn);
                resultTextBox.AppendText(Environment.NewLine);
            }
        }
    }
}
