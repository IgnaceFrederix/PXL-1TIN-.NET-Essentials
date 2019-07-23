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

namespace Oef16_1_Samenvoegen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            samenLabel.Text = "";
        }

        private void samenButton_Click(object sender, EventArgs e)
        {
            samenLabel.Text = String.Format("{0} ({1}) en {2} ({3}) geeft {4}.",
                                          woord1TextBox.Text, woord1TextBox.Text.Length,
                                          woord2TextBox.Text, woord2TextBox.Text.Length,
                                          woord1TextBox.Text + woord2TextBox.Text);
        }
    }
}
