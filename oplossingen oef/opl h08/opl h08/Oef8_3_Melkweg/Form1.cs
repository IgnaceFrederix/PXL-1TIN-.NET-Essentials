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

namespace Oef8_3_Melkweg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void melkwegButton_Click(object sender, EventArgs e)
        {
            int i;
            int x;
            int y;
            int straal;
            Graphics paper;
            SolidBrush myBrush = new SolidBrush(Color.Yellow);
            Random randomNum = new Random();
            paper = hemelPictureBox.CreateGraphics();
            for (i = 0; i < 100; i++)
            {
                x = randomNum.Next(1, hemelPictureBox.Width);
                y = randomNum.Next(1, hemelPictureBox.Height);
                straal = randomNum.Next(1, 100);
                paper.FillEllipse(myBrush, x, y, straal, straal);
            }
        }
    }
}
