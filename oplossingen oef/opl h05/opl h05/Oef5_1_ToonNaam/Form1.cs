﻿//-----------------------------------------------------------------------------
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

namespace Oef5_1_ToonNaam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toonButton_Click(object sender, EventArgs e)
        {
            ToonNaam(voornaamTextBox.Text);
        }

        private void ToonNaam(string voornaam)
        {
            MessageBox.Show("De ingegeven voornaam was: " + voornaam); 
        }
    }
}
