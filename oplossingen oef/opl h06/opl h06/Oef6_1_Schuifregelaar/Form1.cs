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

namespace Oef6_1_Schuifregelaar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            waardeTrackBar.Minimum = Convert.ToInt32(minTextBox.Text);
            waardeTrackBar.Maximum = Convert.ToInt32(maxTextBox.Text);
            minLabel.Text = Convert.ToString(waardeTrackBar.Minimum);
            maxLabel.Text = Convert.ToString(waardeTrackBar.Maximum);
        }

        private void waardeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("De minimumwaarde is " + minLabel.Text + " en de maximumwaarde is " + maxLabel.Text);
        }


    }
}
