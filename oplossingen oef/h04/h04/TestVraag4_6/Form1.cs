//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------
// Programmeren in C#
// Oefeningen en voorbeelden
// Auteur: Kris Hermans
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestVraag4_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalSeconds = 307;
            int seconds, minutes;
            minutes = totalSeconds / 60;
            seconds = totalSeconds % 60;

            string message = String.Format("{0} minutes and {1} seconds", minutes, seconds);
            MessageBox.Show(message);
        }
    }
}
