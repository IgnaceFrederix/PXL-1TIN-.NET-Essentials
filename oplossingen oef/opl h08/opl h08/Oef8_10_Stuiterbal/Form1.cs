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

namespace Oef8_10_Stuiterbal
{
    public partial class Form1 : Form
    {
        private int x, y, diameter;
        private int oudeX, oudeY;

        // xChange en yChange dezelfde waarde geven als je in een hoek van 90° 
        // wil laten botsen. Hoe kleiner de waarde, hoe vloeiender de beweging
        private int xChange = 2;
        private int yChange = 2;
        private Graphics paper;
        private int holeX, holeY;
        private SolidBrush myDarkGreenBrush = new SolidBrush(Color.DarkGreen);

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            oudeX = 0;
            oudeY = 0;
            x = 2;
            y = 2;
            diameter = 30;
            holeX = Convert.ToInt32(((Panel1.Width - diameter) / 2) - 4);
            holeY = Convert.ToInt32(((Panel1.Height - diameter) / 2) - 4);
            paper = Panel1.CreateGraphics();
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            StartUp();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            StartUp();
        }

        private void StartUp()
        {
            paper.Clear(Panel1.BackColor);
            // teken hole iets groter dan bal
            paper.FillEllipse(myDarkGreenBrush, holeX, holeY, diameter + 8, diameter + 8);
            Timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DrawBall(oudeX, oudeY, x, y, diameter, Panel1.BackColor, Color.Red);
            MoveBall(ref xChange, ref yChange);
        }

        private void DrawBall(int oudeX, int oudeY, int X, int Y, int diameter, Color achtergrondkleur, Color kleur)
        {
            SolidBrush myRedBrush = new SolidBrush(kleur);
            SolidBrush myAchtergrondBrush = new SolidBrush(achtergrondkleur);
            // If oudeX = X Then paper.Clear(Panel1.BackColor)
            // verwijder oude bal en teken nieuwe
            paper.FillEllipse(myAchtergrondBrush, oudeX, oudeY, diameter, diameter);
            paper.FillEllipse(myRedBrush, X, Y, diameter, diameter);
            // volgend zin is nodig omdat anders een stukje van hole verdwijnt als rode
            // bal erover gaat
            paper.FillEllipse(myDarkGreenBrush, holeX, holeY, diameter + 8, diameter + 8);
        }

        private void MoveBall(ref int xChange, ref int yChange)
        {
            if (x <= 0)
            {
                xChange = xChange * -1;
            }
            if (x >= (Panel1.Width - diameter))
            {
                xChange = xChange * -1;
            }
            if (y <= 0)
            {
                yChange = yChange * -1;
            }
            if (y >= (Panel1.Height - diameter))
            {
                yChange = yChange * -1;
            }
            // laat bal verdwijnen in hole
            if (((x - holeX) >= 0) && ((x - holeX) <= 8) && ((y - holeY) >= 0) && ((y - holeY) <= 8))
            {
                Timer1.Stop();
                DrawBall(holeX, holeY, holeX, holeY, diameter, Color.DarkGreen, Color.DarkGreen);
            }
            // Om bal in hole te zien gaan, verklein Panel1 of versnel timer
            oudeX = x;
            oudeY = y;
            x = x + xChange;
            y = y + yChange;
        }
    }
}
