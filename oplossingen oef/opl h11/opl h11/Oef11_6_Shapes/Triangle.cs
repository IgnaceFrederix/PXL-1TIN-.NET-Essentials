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
    public class Triangle : Shape
    {

        public override double Area()
        {
            return Width * Height / 2;
        }

        public override void Display(Graphics g, Pen pen)
        {
            g.DrawLine(pen, X, Y, X, Height);
            g.DrawLine(pen, X, Height, X + Width, Height);
            g.DrawLine(pen, X + Width, Height, X, Y);
        }

        public override double Circumference()
        {
            // Pythagoras
            return Width + Height + Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
        }

        public override string ToString()
        {
            return "Triangle " + base.ToString();
        }

    }
}
