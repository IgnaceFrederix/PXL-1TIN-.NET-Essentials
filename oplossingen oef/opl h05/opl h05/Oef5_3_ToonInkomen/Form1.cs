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
//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System.Text;
using System.Windows.Forms;

namespace Oef5_3_ToonInkomen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void berekenButton_Click(object sender, EventArgs e)
        {
            int jaarSalaris = Convert.ToInt32(jaarSalarisTextBox.Text);
            int aantalJaren = Convert.ToInt32(aantalJarenTextBox.Text);
            ToonInkomen(jaarSalaris, aantalJaren);
        }

        private void ToonInkomen(int salaris, int jarenGewerkt)
        {
            int resultaat = salaris * jarenGewerkt;
            MessageBox.Show(String.Format("De werknemer heeft {0} verdiend.", resultaat));
        }
    }
}
