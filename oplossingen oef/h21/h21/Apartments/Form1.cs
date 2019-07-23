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

namespace Apartments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawFlats(int floors, int flats)
        {
            int x, y;

            Graphics paper = apartmentsPictureBox.CreateGraphics();
            paper.Clear(Color.White);
            Pen pen = new Pen(Color.Black);
            y = 10;
            for (int floor = 0; floor < floors; floor++)
            {
                x = 10;
                for (int flat = 0; flat < flats; flat++)
                {
                    paper.DrawRectangle(pen, x, y, 10, 5);
                    x = x + 15;
                }
                y = y + 15;
            }
        }

        private void DrawFlats2(int floors, int flats)
        {
            int y = 10;
            Graphics paper = apartmentsPictureBox.CreateGraphics();
            paper.Clear(Color.White);
            Pen pen = new Pen(Color.Black);
            for (int floor = 0; floor < floors; floor++)
            {
                DrawFloor(y, flats, paper, pen);
                y += 15;
            }
        }

        private void DrawFloor(int y, int flats, Graphics paper, Pen pen)
        {
            int x = 10;
            for (int flat = 0; flat < flats; flat++)
            {
                paper.DrawRectangle(pen, x, y, 10, 5);
                x += 15;
            }
        }

        private void apartmentsPictureBox_Click(object sender, EventArgs e)
        {
            DrawFlats2(7, 8);
        }
    }
}
