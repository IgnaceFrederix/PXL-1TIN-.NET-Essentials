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

namespace BalloonInterface
{
    public class Square : IDisplayable
    {
        private int x, y;
        private int size;

        public void Display(Graphics drawArea)
        {
            Pen pen = new Pen(Color.Black);
            drawArea.DrawRectangle(pen, x, y, size, size);
        }

        // other methods and properties
    }
}
