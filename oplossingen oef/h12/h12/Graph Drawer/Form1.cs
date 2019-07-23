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

namespace Graph_Drawer
{
    public partial class Form1 : Form
    {
        private double a, b, c, d;
        private Graphics paper;
        private Pen pen = new Pen(Color.Black);

        public Form1()
        {
            InitializeComponent();

            paper = graphPictureBox.CreateGraphics();
            aTrackBar.Scroll += TrackBar_Scroll;
            bTrackBar.Scroll += TrackBar_Scroll;
            cTrackBar.Scroll += TrackBar_Scroll;
            dTrackBar.Scroll += TrackBar_Scroll;
        }

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            a = aTrackBar.Value;
            aLabel.Text = "a = " + a;
            b = bTrackBar.Value;
            bLabel.Text = "b = " + b;
            c = cTrackBar.Value;
            cLabel.Text = "c = " + c;
            d = dTrackBar.Value;
            dLabel.Text = "d = " + d;
            paper.Clear(Color.White);
            Draw();
        }

        private void Draw()
        {
            double x, y, nextX, nextY;
            int xPixel, yPixel, nextXPixel, nextYPixel;

            for (xPixel = 0; xPixel <= graphPictureBox.Width; xPixel++)
            {
                x = ScaleX(xPixel);
                y = TheFunction(x);
                yPixel = ScaleY(y);
                nextXPixel = xPixel + 1;
                nextX = ScaleX(nextXPixel);
                nextY = TheFunction(nextX);
                nextYPixel = ScaleY(nextY);
                paper.DrawLine(pen, xPixel, yPixel,
                               nextXPixel, nextYPixel);
            }
        }

        private double TheFunction(double x)
        {
            return a * x * x * x + b * x * x + c * x + d;
        }

        private double ScaleX(int xPixel)
        {
            double xStart = -5;
            double xEnd = 5;
            double xScale = graphPictureBox.Width / (xEnd - xStart);
            return (xPixel - (graphPictureBox.Width / 2)) / xScale;
        }

        private int ScaleY(double y)
        {
            double yStart = -5;
            double yEnd = 5;
            double yScale = graphPictureBox.Height / (yEnd - yStart);
            int pixelCoord = Convert.ToInt32(-y * yScale) +
                             Convert.ToInt32(graphPictureBox.Height / 2);
            return pixelCoord;
        }
    }
}
