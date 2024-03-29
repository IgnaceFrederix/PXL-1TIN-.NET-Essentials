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

namespace Oef23_4_Circle
{
    public class Square : Shape
    {
        public Square(int initX, int initY)
        {
            x = initX;
            y = initY;
        }

        public override void Display(Graphics drawArea)
        {
            drawArea.DrawRectangle(myPen, x, y, size, size);
        }

    }
}
