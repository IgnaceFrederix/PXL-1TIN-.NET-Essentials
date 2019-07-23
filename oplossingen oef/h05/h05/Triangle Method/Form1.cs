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

namespace Triangle_Method
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
            DrawLogo(paper, pen, 10, 20);
            DrawLogo(paper, pen, 100, 100);
            DrawTriangle(paper, pen, 100, 10, 40, 40);
            DrawTriangle(paper, pen, 10, 100, 20, 60);
        }

        private void DrawLogo(Graphics drawingArea,
                              Pen penToUse,
                              int xPos,
                              int yPos)
        {
            drawingArea.DrawRectangle(penToUse, xPos, yPos, 60, 60);
            drawingArea.DrawRectangle(penToUse, xPos, yPos, 40, 40);
            drawingArea.DrawRectangle(penToUse, xPos, yPos, 20, 20);
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

        private void DrawTriangle2(Graphics drawingArea,
                                  Pen penToUse,
                                  int xPlace,
                                  int yPlace,
                                  int width,
                                  int height)
        {
            int rightCornerX, rightCornerY;
            rightCornerX = xPlace + width;
            rightCornerY = yPlace + height;

            drawingArea.DrawLine(penToUse, xPlace, yPlace,
                                 xPlace, rightCornerY);
            drawingArea.DrawLine(penToUse, xPlace, rightCornerY,
                                 rightCornerX, rightCornerY);
            drawingArea.DrawLine(penToUse, xPlace, yPlace,
                                 rightCornerX, rightCornerY);
        }

      
    }
}
