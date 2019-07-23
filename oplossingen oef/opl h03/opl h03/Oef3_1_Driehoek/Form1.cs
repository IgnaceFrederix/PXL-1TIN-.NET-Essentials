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

namespace Oef3_1_Driehoek
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
            Pen pen = new Pen(Color.Blue);

            paper.DrawLine(pen, 10, 10, 250, 10);
            paper.DrawLine(pen, 10, 10, 10, 186);
            paper.DrawLine(pen, 10, 186, 250, 10);
        }
    }
}
