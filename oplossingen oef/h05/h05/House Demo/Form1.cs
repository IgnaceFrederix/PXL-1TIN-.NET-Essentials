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

namespace House_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics paper;
            paper = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            DrawHouse(paper, pen, 10, 20, 70, 20);
            DrawHouse(paper, pen, 10, 90, 50, 50);
        }

        private void DrawHouse(Graphics drawingArea,
                               Pen penToUse,
                               int topRoofX,
                               int topRoofY,
                               int width,
                               int height)
        {
             DrawTriangle(drawingArea, penToUse, topRoofX,
                     topRoofY, width, height);
             drawingArea.DrawRectangle(penToUse, topRoofX,
                                       topRoofY + height, width, height);
        }

        private void DrawTriangle(Graphics drawingArea,
                                  Pen penToUse,
                                  int xPlace,
                                  int yPlace,
                                  int width,
                                  int height)
        {
            drawingArea.DrawLine(penToUse, xPlace, yPlace,
                                 xPlace, yPlace + height);
            drawingArea.DrawLine(penToUse, xPlace,
                                 yPlace + height,
                                 xPlace + width, yPlace + height);
            drawingArea.DrawLine(penToUse, xPlace, yPlace,
                                 xPlace + width, yPlace + height);
        }
    }
}
