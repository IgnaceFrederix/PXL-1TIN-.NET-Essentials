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

namespace Oef4_7_UrenMinutenSeconden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toonButton_Click(object sender, EventArgs e)
        {
            int totaalAantalSeconden = 2549;


            int uren = totaalAantalSeconden / 3600;
            int seconden = totaalAantalSeconden % 3600;
            int minuten = seconden / 60;
            seconden = seconden % 60;

            string result = String.Format("H:{0:d} M:{1:d} S:{2:d}", uren, minuten, seconden);
            MessageBox.Show(result);
        }
    }
}
