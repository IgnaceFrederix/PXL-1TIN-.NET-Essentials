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
    public class Circle : Shape
    {
        public override int Width
        {
            get { return base.Width; }
            // Width = Height bij een circel
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            get { return base.Height; }
            // Width = Height bij een circel
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Width / 2, 2);
        }

        public override double Circumference()
        {
            return Math.PI * Width;
        }

        public override void Display(Graphics g, Pen pen)
        {
            g.DrawEllipse(pen, X, Y, Width, Height);
        }

        public override string ToString()
        {
            return "Circle " + base.ToString();
        }
    }
}
