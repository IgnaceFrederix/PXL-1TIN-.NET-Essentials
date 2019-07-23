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

namespace Oef24_3_IDisplayable
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
            Circle circle = new Circle(20, 20);
            Square square = new Square(80, 80);
            Line line = new Line(150, 90, 150, 150);

            List<IDisplayable> group = new List<IDisplayable>();
            group.Add(circle);
            group.Add(square);
            group.Add(line);

            foreach (IDisplayable shape in group)
	        {
                shape.Display(paper);
	        }
        }
    }
}
