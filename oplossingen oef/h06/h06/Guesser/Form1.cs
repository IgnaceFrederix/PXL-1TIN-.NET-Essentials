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

namespace Guesser
{
    public partial class Form1 : Form
    {
        private Random ageGuesser = new Random();
        private int tries = 0;

        public Form1()
        {
            InitializeComponent();
            guessLabel.Text = Convert.ToString(ageGuesser.Next(5, 110));
        }

        private void correctButton_Click(object sender, EventArgs e)
        {
            tries = tries + 1;
            MessageBox.Show("Number of tries was: " + tries);
            tries = 0;
            guessLabel.Text = Convert.ToString(ageGuesser.Next(5, 110));
        }

        private void wrongButton_Click(object sender, EventArgs e)
        {
            guessLabel.Text = Convert.ToString(ageGuesser.Next(5, 110));
            tries = tries + 1;
        }


    }
}
