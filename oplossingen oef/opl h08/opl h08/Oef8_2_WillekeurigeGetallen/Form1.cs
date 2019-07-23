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

namespace Oef8_2_WillekeurigeGetallen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toonButton_Click(object sender, EventArgs e)
        {
            int getal;
            Random randomNumber = new Random();
            for (int i = 0; i < 10; i++)
            {
                getal = randomNumber.Next(1, 100);
                getallenTextBox.AppendText(getal + "\n");
            }
        }
    }
}
