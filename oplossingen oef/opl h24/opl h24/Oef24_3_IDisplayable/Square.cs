//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef24_3_IDisplayable
{
    public class Square : Shape
    {
        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override void Display(System.Drawing.Graphics area)
        {
            area.DrawRectangle(pen, x, y, size, size);
        }
    }
}
