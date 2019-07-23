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

namespace Bouncing_ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ballPictureBox_Click(object sender, EventArgs e)
        {
            int x, y, diameter;
            int xChange = 7;
            int yChange = 2;

            x = 10;
            y = 10;
            diameter = 10;
            for (int count = 0; count < 200; count++)
            {
                MoveBall(ref x, ref y, ref xChange, ref yChange);
                DrawBall(x, y, diameter);
            }
        }

        private void MoveBall(ref int x, ref int y,
                              ref int xChange, ref int yChange)
        {
            if ((x <= 0) || (x >= ballPictureBox.Width))
            {
                xChange = -xChange;
            }
            if ((y <= 0) || (y >= ballPictureBox.Height))
            {
                yChange = -yChange;
            }

            x = x + xChange;
            y = y + yChange;
        }

        private void DrawBall(int x, int y, int diameter)
        {
            Graphics paper = ballPictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            paper.DrawEllipse(pen, x, y, diameter, diameter);
        }
    }
}
