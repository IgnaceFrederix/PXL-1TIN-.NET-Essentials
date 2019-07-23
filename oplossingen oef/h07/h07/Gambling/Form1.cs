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

namespace Gambling
{
    public partial class Form1 : Form
    {
        private Random randomNumber = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void throwButton_Click(object sender, EventArgs e)
        {
            int die1, die2;

            die1 = randomNumber.Next(1, 7);
            die2 = randomNumber.Next(1, 7);

            valuesLabel.Text = String.Format("The die values are {0} and {1}",
                                             die1, die2);

            if (die1 == die2)
            {
                outcomeLabel.Text = "dice equal - a win";
            }
            else
            {
                outcomeLabel.Text = "dice not equal - lose";
            }
        }
    }
}
