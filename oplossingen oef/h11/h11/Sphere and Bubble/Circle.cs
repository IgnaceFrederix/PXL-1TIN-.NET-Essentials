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
    public class Circle : Shape
    {
        public override void Display(Graphics drawArea)
        {
            drawArea.DrawEllipse(pen, xCoord, yCoord, size, size);
        }
    }
}
