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

namespace FormatDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void intButton_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(intTextBox.Text);
            resultLabel.Text = "{0:" + formatTextBox.Text + "} wordt " + 
                               String.Format("{0:" + formatTextBox.Text + "}", i);
        }

        private void doubleButton_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(doubleTextBox.Text);
            resultLabel.Text = "{0:" + formatTextBox.Text + "} wordt " + 
                               String.Format("{0:" + formatTextBox.Text + "}", d);
        }
    }
}
