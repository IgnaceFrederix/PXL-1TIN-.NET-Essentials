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

namespace Oef12_2_OmzettingMaten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmLabel.Text = string.Empty;
        }

        private void convertButton_Click(System.Object sender, System.EventArgs e)
        {
            double inches = Convert.ToInt32(feetTextBox.Text) * 12 + Convert.ToInt32(inchesTextBox.Text);
            double cm = inches * 2.54;

            cmLabel.Text = String.Format("{0:0.00} cm", cm);
        }
    }
}
