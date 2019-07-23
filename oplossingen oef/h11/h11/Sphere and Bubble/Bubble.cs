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
    public class Bubble : Sphere
    {
        protected int radius = 10;

        public int Size
        {
            set { radius = value; }
        }

        public override void Display(Graphics drawArea)
        {
            drawArea.DrawEllipse(pen, xCoord, yCoord, 2 * radius, 2 * radius);
        }

        public void MoveVertical(int amount)
        {
            yCoord += amount;
        }
    }
}
