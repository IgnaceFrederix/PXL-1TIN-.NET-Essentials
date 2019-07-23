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

namespace Testvraag8_3_Schaakbord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            int x, y;
            Graphics paper;
            Pen pen = new Pen(Color.Black);

            paper = chessPictureBox.CreateGraphics();
            paper.Clear(Color.White);

            x = 10;
            y = 10;

            for (int counter = 0; counter < 9; counter++)
            {
                paper.DrawLine(pen, x, 10, x, 90);
                paper.DrawLine(pen, 10, y, 90, y);
                x += 10;
                y += 10;
            }
        }
    }
}
