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

namespace Oef3_5_Roos
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
            SolidBrush brush = new SolidBrush(Color.BlueViolet);
            const int centrumX = 130;
            const int centrumY = 98;
            int straal = 80;

            paper.FillEllipse(brush, centrumX - straal, centrumY - straal, 2 * straal, 2 * straal);

            brush = new SolidBrush(Color.Green);
            straal = 60;
            paper.FillEllipse(brush, centrumX - straal, centrumY - straal, 2 * straal, 2 * straal);

            brush = new SolidBrush(Color.Red);
            straal = 40;
            paper.FillEllipse(brush, centrumX - straal, centrumY - straal, 2 * straal, 2 * straal);

            brush = new SolidBrush(Color.Chocolate);
            straal = 20;
            paper.FillEllipse(brush, centrumX - straal, centrumY - straal, 2 * straal, 2 * straal);

            brush = new SolidBrush(Color.Black);
            straal = 5;
            paper.FillEllipse(brush, centrumX - straal, centrumY - straal, 2 * straal, 2 * straal);
        }
    }
}
