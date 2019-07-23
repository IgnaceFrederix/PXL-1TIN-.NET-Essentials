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

namespace Oef3_4_Regenval
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Graphics paper = drawAreaPictureBox.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Blue);
            const int unitHeight = 20;

            paper.FillRectangle(brush, 10, 10, 150, unitHeight);
            paper.FillRectangle(brush, 10, 10 + 2 * unitHeight, 175, unitHeight);
            paper.FillRectangle(brush, 10, 10 + 4 * unitHeight, 120, unitHeight);
            paper.FillRectangle(brush, 10, 10 + 6 * unitHeight, 130, unitHeight);
        }
    }
}
