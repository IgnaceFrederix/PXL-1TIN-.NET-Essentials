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

namespace Oef23_4_Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void shapesPictureBox_Click(System.Object sender, System.EventArgs e)
        {
            Graphics paper = shapesPictureBox.CreateGraphics();
            IDisplayable circle1 = new Circle(20, 20);
            IDisplayable square1 = new Square(80, 80);
            List<IDisplayable> group = new List<IDisplayable>();

            group.Add(circle1);
            group.Add(square1);

            foreach (IDisplayable aDisplay in group)
            {
                aDisplay.Display(paper);
            }
        }
    }
}
