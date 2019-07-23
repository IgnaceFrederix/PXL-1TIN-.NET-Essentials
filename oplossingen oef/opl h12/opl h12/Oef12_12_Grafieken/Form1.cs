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

namespace Oef12_12_Grafieken
{
    public partial class Form1 : Form
    {
        private double a, b, c, d;
        private Graphics paper;
        private Pen myPen = new Pen(Color.Black);
        private Pen axPen = new Pen(Color.Blue);

        public Form1()
        {
            InitializeComponent();

            paper = PictureBox1.CreateGraphics();
        }

        private void btnTeken_Click(object sender, System.EventArgs e)
        {
            DrawGraph();
            DrawAxes();
        }
    
        private void DrawAxes() {
            paper.DrawLine(axPen, 0, Convert.ToInt32(PictureBox1.Height / 2),
                                     Convert.ToInt32(PictureBox1.Width),
                                     Convert.ToInt32(PictureBox1.Height / 2));
            paper.DrawLine(axPen, Convert.ToInt32(PictureBox1.Width / 2), 0,
                                  Convert.ToInt32(PictureBox1.Width / 2),
                                  PictureBox1.Height);
        }
    
        private void DrawGraph() {
            a = Convert.ToInt32(aTextBox.Text);
            b = Convert.ToInt32(bTextBox.Text);
            c = Convert.ToInt32(cTextBox.Text);
            d = Convert.ToInt32(dTextBox.Text);
            paper.Clear(Color.White);
            Draw();
        }

        private void Draw() {
            double x;
            double y;
            double nextX;
            double nextY;
            int xPixel;
            int yPixel;
            int nextXPixel;
            int nextYPixel;
            for (xPixel = 0; xPixel <= PictureBox1.Width; xPixel++) {
                x = ScaleX(xPixel);
                y = TheFunction(x);
                yPixel = ScaleY(y);
                nextXPixel = xPixel + 1;
                nextX = ScaleX(nextXPixel);
                nextY = TheFunction(nextX);
                nextYPixel = ScaleY(nextY);
                paper.DrawLine(myPen, xPixel, yPixel, nextXPixel, nextYPixel);
            }
        }

        private double TheFunction(double x)
        {
            return a * x * x * x + b * x * x + c * x + d;
        }

        private double ScaleX(int xPixel)
        {
            double xStart = -5 / horizontalTrackBar.Value;
            double xEnd = 5 / horizontalTrackBar.Value;
            double xScale = PictureBox1.Width / (xEnd - xStart);
            return (xPixel - (PictureBox1.Width / 2)) / xScale;
        }

       private int ScaleY(double y)
        {
            double yStart = -5 / (verticalTrackBar.Maximum + 1 - verticalTrackBar.Value);
            double yEnd = 5 / (verticalTrackBar.Maximum + 1 - verticalTrackBar.Value);
            double yScale = PictureBox1.Height / (yEnd - yStart);
            int pixelCoord = Convert.ToInt32(-y * yScale) +
                             Convert.ToInt32(PictureBox1.Height / 2);
            return pixelCoord;
        }
    }
}
