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

namespace Oef5_4_Cirkel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tekenButton_Click(object sender, EventArgs e)
        {
            Graphics paper = cirkelPictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            int middelX = Convert.ToInt32(mxTextBox.Text);
            int middelY = Convert.ToInt32(myTextBox.Text);
            int straal = Convert.ToInt32(straalTextBox.Text);
            Circle(paper, pen, middelX, middelY, straal);
        }

        private void Circle(Graphics drawArea,
                            Pen pen,
                            int xCentre, int yCentre, int radius)
        {
            drawArea.Clear(Color.White);
            drawArea.DrawEllipse(pen, xCentre - radius, yCentre - radius, 2 * radius, 2 * radius);
        }
    }
}
