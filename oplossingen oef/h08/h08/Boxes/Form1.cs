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

namespace Boxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countTrackBar_Scroll(object sender, EventArgs e)
        {
            int x, numberOfBoxes, counter;
            Graphics paper;
            Pen pen = new Pen(Color.Black);

            numberOfBoxes = countTrackBar.Value;
            paper = boxesPictureBox.CreateGraphics();
            paper.Clear(Color.White);
            x = 10;
            for (counter = 1; counter <= numberOfBoxes; counter++)
            {
                paper.DrawRectangle(pen, x, 10, 10, 10);
                x = x + 15;
            }
        }
    }
}
