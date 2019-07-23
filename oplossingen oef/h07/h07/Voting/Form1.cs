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

namespace Voting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int age;
            age = Convert.ToInt32(ageTextBox.Text);

            if (age > 17)
            {
                decisionLabel.Text = "You may vote.";
                commentaryLabel.Text = "Congratulations.";
            }
            else
            {
                decisionLabel.Text = "You may not vote.";
                commentaryLabel.Text = "Sorry.";
            }
            signOffLabel.Text = "Best Wishes";
        }
    }
}
