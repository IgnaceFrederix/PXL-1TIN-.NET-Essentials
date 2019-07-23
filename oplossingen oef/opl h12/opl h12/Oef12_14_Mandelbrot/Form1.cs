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

namespace Oef12_14_Mandelbrot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawMandelbrot()
        {
            Graphics paper = pictureBox1.CreateGraphics();
            int xPixelStart = 0;
            int xPixelEnd = pictureBox1.Width;
            int xOrigin = Convert.ToInt32(pictureBox1.Width / 2) - 50;
            int yPixelStart = 0;
            int yPixelEnd = pictureBox1.Height;
            int yOrigin = Convert.ToInt32(pictureBox1.Height / 2);
            double xStart = -1.5; // Kris, in handboek (opgave) staat -1.0
            double xEnd = 2.0;
            double yStart = -2;
            double yEnd = 2; // Kris, een niet gebruikte variabele
            double scale = (xPixelEnd - xPixelStart) / (xEnd - xStart);

            int xPixel = xPixelStart;
            while (xPixel <= xPixelEnd)
            {
                int yPixel = yPixelStart;
                while (yPixel <= yPixelEnd)
                {
                    xStart = ScaleX(xPixel, xOrigin, scale);
                    yStart = ScaleY(yPixel, yOrigin, scale);
                    double r = Iteration(xStart, yStart);
                    SolidBrush brush;
                    if (r > 10000)
                    {
                        brush = new SolidBrush(Color.White);
                    }
                    else
                    {
                        brush = new SolidBrush(Color.Black);
                    }
                    paper.FillRectangle(brush, xPixel, yPixel, 1, 1);
                    yPixel++;
                }
                xPixel++;
            }

        }

        private double Iteration(double xStart, double yStart)
        {
            double r = 0;
            double xOld = xStart;
            double yOld = yStart;

            int n = 1;

            while ((n < 100) && (r < 10000))
            {
                double xNew = xOld * xOld - yOld * yOld - xStart;
                double yNew = 2 * xOld * yOld - yStart;
                r = Math.Sqrt(xOld * xOld + yOld * yOld);

                xOld = xNew;
                yOld = yNew;
                n++;
            }

            return r;
        }

        private double ScaleX(int xPixel, int xOrigin, double scale)
        {
            return (xPixel - xOrigin) / scale;
        }

        private double ScaleY(int yPixel, int yOrigin, double scale)
        {
            return (yOrigin - yPixel) / scale;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DrawMandelbrot();
        }
    }
}
