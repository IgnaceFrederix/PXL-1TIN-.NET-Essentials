//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Oef20_1_Balloon
{
    public class Balloon
    {
        private int radius = 100;
        private int xCoordinate = 10;

        private int yCoordinate = 10;

        public void MoveUp()
        {
            yCoordinate = yCoordinate - 10;
        }

        public void MoveDown()
        {
            yCoordinate = yCoordinate + 10;
        }

        public void Display(PictureBox myPictureBox)
        {
            Graphics paper = null;
            Pen myPen = new Pen(Color.Black);

            paper = myPictureBox.CreateGraphics();
            paper.Clear(Color.White);

            int diameter = radius * 2;
            paper.DrawEllipse(myPen, xCoordinate, yCoordinate, diameter, diameter);
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
    }
}
