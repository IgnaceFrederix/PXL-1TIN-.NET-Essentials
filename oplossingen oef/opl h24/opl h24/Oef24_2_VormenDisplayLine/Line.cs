//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef24_2_VormenDisplayLine
{
    public class Line : Shape
    {
        private int x2;
        private int y2;

        public Line(int x, int y, int x2, int y2)
        {
            this.x = x;
            this.y = y;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void Display(System.Drawing.Graphics area)
        {
            area.DrawLine(pen, x, y, x2, y2);
        }
    }
}
