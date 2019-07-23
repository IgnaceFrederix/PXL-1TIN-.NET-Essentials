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

namespace Triangle_Method_Parameters
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
            DrawTriangle3(paper, pen, 100, 10, 40, 40);
            DrawTriangle3(paper, pen, 10, 100, 20, 60);
            DrawTriangle3(paper, pen);
            DrawTriangle3(paper, pen, 50, 50);
            DrawTriangle3(paper, pen, width: 15, height: 50);
            DrawTriangle3(height: 150, width: 150, drawingArea: paper, penToUse: pen);
        }

        private void DrawTriangle3(Graphics drawingArea,
                                  Pen penToUse,
                                  int xPlace = 0,
                                  int yPlace = 0,
                                  int width = 30,
                                  int height = 30)
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

        private void Alert(string message, string title = "Alert")
        {
            MessageBox.Show(message, title);
        }
    }
}
