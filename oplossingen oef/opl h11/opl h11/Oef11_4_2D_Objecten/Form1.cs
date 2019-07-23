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

namespace Oef11_4_2D_Objecten
{
    public partial class Form1 : Form
    {
        private Pen pen = new Pen(Color.BlueViolet);
        private Graphics paper;

        public Form1()
        {
            InitializeComponent();

            paper = pictureBox1.CreateGraphics();
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            CreateShape(new Rectangle());
        }

        private void triangleButton_Click(object sender, EventArgs e)
        {
            CreateShape(new Triangle());
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            CreateShape(new Square());
        }

        private void CreateShape(Shape s)
        {
            s.X = Convert.ToInt32(pictureBox1.Width / 2);
            s.Y = Convert.ToInt32(pictureBox1.Height / 2);
            s.Width = 80;
            s.Height = 60;

            paper.Clear(Color.White);
            s.Display(paper, pen);
            statusLabel.Text = s.ToString();
        }
    }
}
