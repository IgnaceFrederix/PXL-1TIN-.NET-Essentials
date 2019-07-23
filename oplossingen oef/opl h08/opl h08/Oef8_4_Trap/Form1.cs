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

namespace Oef8_4_Trap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trapPictureBox_Click(object sender, EventArgs e)
        {
            Graphics paper = trapPictureBox.CreateGraphics();
            paper.Clear(Color.White);
            Pen pen = new Pen(Color.Black);
            int y = 10;

            for (int height = 1; height <= 6; height++)
            {
                int x = 10;
                for (int width = 1; width <= height; width++)
                {
                    paper.DrawRectangle(pen, x, y, 10, 10);
                    x += 15;
                }
                y += 15;
            }
        }
    }
}
