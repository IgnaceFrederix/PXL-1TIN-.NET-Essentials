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

namespace Remember
{
    public partial class Form1 : Form
    {
        private bool filled;

        public Form1()
        {
            InitializeComponent();
            int a = 10;
            int b = 20;
            string msg = (a > b) ? "a is greater" : "b is greater";
            MessageBox.Show(msg);
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            filled = true;
        }

        private void unfillButton_Click(object sender, EventArgs e)
        {
            filled = false;
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);
            paper.Clear(Color.White);
            if (filled)
            {
                paper.FillRectangle(brush, 10, 10, 100, 100);
            }
            else
            {
                paper.DrawRectangle(pen, 10, 10, 100, 100);
            }
        }
    }
}
