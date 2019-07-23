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

namespace Oef12_5_RandomGetallen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genereerButton_Click(object sender, EventArgs e)
        {
            int aantal1 = 0;
            int aantal2 = 0;
            Random random = new Random();
            int getal = 0;
            for (int index = 1; index <= 100; index++)
            {
                getal = random.Next(1, 3);
                if ((getal == 1))
                {
                    aantal1 = (aantal1 + 1);
                }
                else
                {
                    aantal2 = (aantal2 + 1);
                }
            }
            random1Label.Text = Convert.ToString(aantal1);
            random2Label.Text = Convert.ToString(aantal2);
        }
    }
}
