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

namespace BalloonWithProperties
{
    public class BalloonWithProperties
    {
        private int x = 50;
        private int y = 50;
        private int diameter = 20;
        private Pen pen = new Pen(Color.Black);

        public void MoveRight(int xStep)
        {
            x = x + xStep;
        }

        public void ChangeSize(int change)
        {
            diameter = diameter + change;
        }

        public void Display(Graphics drawArea)
        {
            drawArea.DrawEllipse(pen, x, y, diameter, diameter);
        }

        public int XCoord
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int YCoord
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
}
