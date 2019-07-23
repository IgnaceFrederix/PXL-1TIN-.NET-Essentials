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

namespace StringComparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            if (string1TextBox.Text.CompareTo(string2TextBox.Text) < 0)
            {
                resultLabel.Text = string1TextBox.Text + " komt voor " +
                                   string2TextBox.Text;
            }
            else
            {
                resultLabel.Text = string2TextBox.Text + " komt voor " +
                                   string1TextBox.Text;
            }

        }
    }
}
