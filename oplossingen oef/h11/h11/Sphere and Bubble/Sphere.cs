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

namespace Sphere_and_Bubble
{
    public class Sphere
    {
        protected int xCoord = 100;
        protected int yCoord = 100;
        protected Pen pen = new Pen(Color.Black);

        public int X
        {
            set { xCoord = value; }
        }

        public int Y
        {
            set { yCoord = value; }
        }

        public virtual void Display(Graphics drawArea)
        {
            drawArea.DrawEllipse(pen, xCoord, yCoord, 20, 20);
        }
    }
}
