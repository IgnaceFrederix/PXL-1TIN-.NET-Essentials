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

namespace Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //trackBar1.Scroll += CheckWhenScroll;
            //trackBar2.Scroll += CheckWhenScroll;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            CheckValues();
        }

        private void CheckValues()
        {
            int die1, die2, total;

            die1 = trackBar1.Value;
            die2 = trackBar2.Value;
            total = die1 + die2;
            totalLabel.Text = "total is " + total;
            if (total == 6)
            {
                statusLabel.Text = "You have won";
            }
            else
            {
                statusLabel.Text = "You have lost";
            }
        }

        private void CheckWhenScroll(object sender, EventArgs e)
        {
            CheckValues();
        }
    }
}
