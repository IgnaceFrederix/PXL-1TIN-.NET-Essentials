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

namespace Testvraag8_2_Tralies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            int x, numberOfBars;
            Graphics paper;
            Pen pen = new Pen(Color.Black);

            numberOfBars = 5;
            paper = traliesPictureBox.CreateGraphics();
            paper.Clear(Color.White);
            x = 10;
            for (int counter = 0; counter < numberOfBars; counter++)
            {
                paper.DrawLine(pen, x, 10, x, 100);
                x = x + 15;
            }
        }
    }
}
