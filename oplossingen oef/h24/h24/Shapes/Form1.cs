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

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void shapesPictureBox_Click(object sender, EventArgs e)
        {
            Graphics paper = shapesPictureBox.CreateGraphics();
            Circle circle1 = new Circle(20, 20);
            Square square1 = new Square(80, 80);
            List<Shape> group = new List<Shape>();

            group.Add(circle1);
            group.Add(square1);

            foreach (Shape shape in group)
            {
                shape.Display(paper);
            }
        }
    }
}
