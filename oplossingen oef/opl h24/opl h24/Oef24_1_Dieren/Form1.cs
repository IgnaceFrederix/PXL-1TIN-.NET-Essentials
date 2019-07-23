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

namespace Oef24_1_Dieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void koeButton_Click(object sender, EventArgs e)
        {
            Dier koe = new Koe();
            koe.Gewicht = 500;
            infoTextBox.Text = koe.ToString();
        }

        private void slangButton_Click(object sender, EventArgs e)
        {
            Dier slang = new Slang();
            slang.Gewicht = 5;
            infoTextBox.Text = slang.ToString();
        }

        private void varkenButton_Click(object sender, EventArgs e)
        {
            Dier varken = new Varken();
            varken.Gewicht = 200;
            infoTextBox.Text = varken.ToString();
        }
    }
}
