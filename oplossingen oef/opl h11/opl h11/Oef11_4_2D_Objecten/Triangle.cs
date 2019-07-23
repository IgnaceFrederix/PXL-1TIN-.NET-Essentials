//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef11_4_2D_Objecten
{
    public class Triangle : Shape
    {
        public override double Area()
        {
            return Width * Height / 2;
        }

        public override void Display(System.Drawing.Graphics g, System.Drawing.Pen p)
        {
            g.DrawLine(p, X, Y, X, Height);
            g.DrawLine(p, X, Height, X + Width, Height);
            g.DrawLine(p, X + Width, Height, X, Y);
        }

        public override string ToString()
        {
            return "Triangle: " + base.ToString();
        }
    }
}
