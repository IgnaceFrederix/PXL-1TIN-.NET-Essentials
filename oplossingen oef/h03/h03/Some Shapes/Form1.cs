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

namespace Some_Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics paper;
            paper = pictureBox1.CreateGraphics();

            // original:
            //Bitmap pic = new Bitmap("C:\\Users\\Kris\\Pictures\\imagedemo.jpg");
            // let op: property imagedemo.jpg
            //    Copy to output dir -> ALWAYS
            Bitmap pic = new Bitmap("imagedemo.jpg");

            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Gray);

            paper.DrawRectangle(pen, 10, 10, 100, 50);
            paper.DrawLine(pen, 10, 10, 110, 60);
            paper.DrawRectangle(pen, 10, 80, 100, 50);
            paper.DrawEllipse(pen, 10, 80, 100, 50);
            paper.FillEllipse(brush, 10, 150, 100, 50);
            paper.DrawRectangle(pen, 130, 10, 150, 150);
            paper.DrawImage(pic, 130, 10, 150, 150);
        }
    }
}
