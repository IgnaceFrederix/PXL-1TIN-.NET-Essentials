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

namespace Oef7_4_Weddenschap
{
    public partial class Form1 : Form
    {
        private int worpen = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Text = "Start";
            startTimer.Start();
            worpen = worpen + 1;
            worpenProgressBar.Value = worpen;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startTimer.Stop();
            Check();
        }

        private void Check()
        {
            if ((getal1Label.Text == "6") &&
                (getal2Label.Text == "6") &&
                (getal3Label.Text == "6"))
            {
                resultLabel.Text = "20";
            }
            else if ((getal1Label.Text == getal2Label.Text) &&
                     (getal2Label.Text == getal3Label.Text) &&
                     (getal1Label.Text != "6"))
            {
                resultLabel.Text = "10";
            }
            else if ((getal1Label.Text == getal2Label.Text) ||
                     (getal1Label.Text == getal3Label.Text) ||
                     (getal2Label.Text == getal3Label.Text))
            {
                resultLabel.Text = "5";
            }
            else
            {
                resultLabel.Text = "0";
            }
            totalLabel.Text = Convert.ToString(Convert.ToInt32(totalLabel.Text) + Convert.ToInt32(resultLabel.Text));

            if (worpen == 20)
            {
                startButton.Text = "Herstart";
                worpen = 0;
            }
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            Random randomNum = new Random();
            getal1Label.Text = Convert.ToString(randomNum.Next(1, 7));
            getal2Label.Text = Convert.ToString(randomNum.Next(1, 7));
            getal3Label.Text = Convert.ToString(randomNum.Next(1, 7));
        }
    }
}
