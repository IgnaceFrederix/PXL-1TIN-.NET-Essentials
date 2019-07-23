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

namespace Oef11_6_Shapes
{
    public partial class Form1 : Form
    {
        private Pen myPen;
        private Graphics paper;
        
        public Form1()
        {
            InitializeComponent();

            myPen = new Pen(Color.BlueViolet);
            paper = drawingPictureBox.CreateGraphics();
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            Shape s = new Rectangle();
            CreateShape(s);

            statusLabel.Text = s.ToString();
        }

        private void CreateShape(Shape s)
        {
            s.X = Convert.ToInt32(drawingPictureBox.Width / 2);
            s.Y = Convert.ToInt32(drawingPictureBox.Height / 2);
            s.Width = 80;
            s.Height = 60;

            paper.Clear(Color.White);
            s.Display(paper, myPen);
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            Shape s = new Triangle();
            CreateShape(s);

            statusLabel.Text = s.ToString();
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            Shape s = new Square();
            s.X = Convert.ToInt32(drawingPictureBox.Width / 2);
            s.Y = Convert.ToInt32(drawingPictureBox.Height / 2);
            s.Width = 50;

            paper.Clear(Color.White);
            s.Display(paper, myPen);

            statusLabel.Text = s.ToString();
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            Shape s = new Circle();
            s.X = Convert.ToInt32(drawingPictureBox.Width / 2);
            s.Y = Convert.ToInt32(drawingPictureBox.Height / 2);
            s.Width = 50;

            paper.Clear(Color.White);
            s.Display(paper, myPen);

            statusLabel.Text = s.ToString();
        }
    }
}
