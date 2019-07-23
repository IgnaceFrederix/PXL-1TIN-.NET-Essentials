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

namespace Oef5_8_KubusVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            double vol = KubusVolume(Convert.ToDouble(ribbeTextBox.Text));
            MessageBox.Show(String.Format("Volume kubus bedraagt {0:0.00}", vol));
        }

        private double KubusVolume(double ribbe)
        {
            return Math.Pow(ribbe, 3);
        }
    }
}
