﻿//-----------------------------------------------------------------------------
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

namespace Oef3_8_Gezicht_Panel_Paint
{
    public partial class Form1 : Form
    {
        private bool geklikt = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            TekenGezicht();
            geklikt = true;
        }

        private void TekenGezicht()
        {
            Graphics paper = drawAreaPanel.CreateGraphics();
            Pen myPen = new Pen(Color.Black);
            SolidBrush myBrush = new SolidBrush(Color.Black);
            Pen myFatPen = new Pen(Color.Black, 3);

            paper.Clear(drawAreaPanel.BackColor);
            //teken gezicht
            paper.DrawEllipse(myFatPen, 40, 40, 60, 80);
            //teken linkeroog
            paper.DrawEllipse(myPen, 55, 60, 10, 14);
            //teken rechteroog
            paper.DrawEllipse(myPen, 75, 60, 10, 14);
            //teken pupillen
            paper.FillEllipse(myBrush, 59, 62, 4, 8);
            paper.FillEllipse(myBrush, 79, 62, 4, 8);
            //teken neus
            paper.DrawEllipse(myPen, 67, 75, 3, 10);
            //teken mond
            paper.DrawEllipse(myPen, 60, 90, 20, 7);
            //teken haar
            paper.DrawLine(myFatPen, 53, 46, 45, 19);
            paper.DrawLine(myFatPen, 68, 40, 68, 6);
            paper.DrawLine(myFatPen, 83, 46, 92, 19);
        }

        private void drawAreaPanel_Paint(object sender, PaintEventArgs e)
        {
            if (geklikt)
            {
                TekenGezicht();
            }
        }
    }
}
