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

namespace Balloons
{
    public class Balloon
    {
        private int x, y;
        private int diameter;

        public Balloon(int initialX,
                       int initialY,
                       int initialDiameter)
        {
            this.x = initialX;
            this.y = initialY;
            this.diameter = initialDiameter;
        }

        public void ChangeSize(int change)
        {
            diameter += change;
        }

        public void Display(Graphics drawArea, Pen pen)
        {
            drawArea.DrawEllipse(pen, x, y, diameter, diameter);
        }
    }
}
