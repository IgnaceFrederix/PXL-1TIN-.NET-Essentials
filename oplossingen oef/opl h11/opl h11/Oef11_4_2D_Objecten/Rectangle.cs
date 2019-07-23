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
    public class Rectangle : Shape
    {
        public override double Area()
        {
            return Width * Height;
        }

        public override void Display(System.Drawing.Graphics g, System.Drawing.Pen p)
        {
            g.DrawRectangle(p, X, Y, Width, Height);
        }

        public override string ToString()
        {
            return "Rectangle: " + base.ToString();
        }
    }
}
