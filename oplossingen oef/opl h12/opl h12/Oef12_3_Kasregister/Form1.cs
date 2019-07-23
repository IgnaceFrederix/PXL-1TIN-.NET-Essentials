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

namespace Oef12_3_Kasregister
{
    public partial class Form1 : Form
    {
        private double som;

        public Form1()
        {
            InitializeComponent();

            Reset();
        }

        private void addButton_Click(System.Object sender, System.EventArgs e)
        {
            som = som + Convert.ToDouble(bedragTextBox.Text);
            somLabel.Text = String.Format("{0:c}",som);
        }

        private void Reset()
        {
            som = 0;
            somLabel.Text = String.Format("{0:c}", som);
        }

        private void resetButton_Click(System.Object sender, System.EventArgs e)
        {
            Reset();
        }
    }
}
