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

namespace Balloon
{
    public class Balloon
    {
        private int x = 30;
        private int y = 30;
        private int radius;

        public void MoveUp(int yStep)
        {
            y -= yStep;
        }

        public void MoveDown(int yStep)
        {
            y += yStep;
        }

        public void Display(Graphics drawArea)
        {
            drawArea.Clear(Color.White);
            Pen pen = new Pen(Color.Black);
            drawArea.DrawEllipse(pen, x, y, 2 * radius, 2 * radius);
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }
    }
}
