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

namespace Oef10_4_Puntenteller
{
    public partial class Form1 : Form
    {
        private Score score;
        
        public Form1()
        {
            InitializeComponent();

            score = new Score();
            scoreLabel.Text = String.Format("{0}", score.Punten);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            score.Reset();
            scoreLabel.Text = String.Format("{0}", score.Punten);
        }

        private void btnVerhoog_Click(object sender, EventArgs e)
        {
            score.Increment();
            scoreLabel.Text = String.Format("{0}", score.Punten);
        }

        private void btnVerlaag_Click(object sender, EventArgs e)
        {
            score.Decrement();
            scoreLabel.Text = String.Format("{0}", score.Punten);
        }
    }
}
