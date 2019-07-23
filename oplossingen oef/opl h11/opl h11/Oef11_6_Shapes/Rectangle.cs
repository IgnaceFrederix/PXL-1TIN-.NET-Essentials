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

namespace Oef11_6_Shapes
{
    public class Rectangle : Shape
    {

        public override double Area()
        {
            return Width * Height;
        }

        public override void Display(Graphics g, Pen pen)
        {
            g.DrawRectangle(pen, X, Y, Width, Height);
        }

        public override double Circumference()
        {
            return 2 * Width + 2 * Height;
        }

        public override string ToString()
        {
            return "Rectangle " + base.ToString();
        }
    }
}
