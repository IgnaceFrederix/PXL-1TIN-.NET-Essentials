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

namespace Oef5_2_ToonNamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toonButton_Click(object sender, EventArgs e)
        {
            ToonNamen(voornaamTextBox.Text, achternaamTextBox.Text);
        }

        private void ToonNamen(string voornaam, string achternaam)
        {
            MessageBox.Show("De ingegeven voornaam was: " + voornaam);
            MessageBox.Show("De ingegeven achternaam was: " + achternaam);
        }
    }
}
