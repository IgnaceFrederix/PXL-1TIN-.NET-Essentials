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

namespace Oef5_15_Invoer3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingevenButton_Click(object sender, EventArgs e)
        {
            int a, b, c;
            Invoer3(out a, out b, out c);
            MessageBox.Show(String.Format("Waarde a = {0}, Waarde b = {1}, Waarde c = {2}", a, b, c));
        }

        private void Invoer3(out int a, out int b, out int c)
        {
            a = Convert.ToInt32(aTextBox.Text);
            b = Convert.ToInt32(bTextBox.Text);
            c = Convert.ToInt32(cTextBox.Text);
        }
    }
}
