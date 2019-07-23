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

namespace Oef11_4_2D_Objecten
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public abstract double Area();
        public abstract void Display(Graphics g, Pen p);

        public override string ToString()
        {
            return String.Format("[{0},{1},{2},{3}]",X, Y, Width, Height);
        }
    }
}
