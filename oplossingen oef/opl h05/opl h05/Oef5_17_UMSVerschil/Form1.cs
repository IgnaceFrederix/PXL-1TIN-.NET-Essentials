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

namespace Oef5_17_UMSVerschil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void verschilButton_Click(object sender, EventArgs e)
        {
            int sec1, sec2, verschil;
            int u, m, s;
            sec1 = Convert.ToInt32(sec1TextBox.Text);
            sec2 = Convert.ToInt32(sec2TextBox.Text);
            verschil = sec1 - sec2;
            SecNaarUMS(verschil, out u, out m, out s);
            MessageBox.Show(String.Format("U: {0} M: {1} S: {2}", u, m, s));
        }

        private void SecNaarUMS(int sec, out int uren, out int minuten, out int seconden)
        {
            uren = sec / 3600;
            sec = sec - uren * 3600;
            minuten = sec / 60;
            seconden = sec % 60;
        }
    }
}
