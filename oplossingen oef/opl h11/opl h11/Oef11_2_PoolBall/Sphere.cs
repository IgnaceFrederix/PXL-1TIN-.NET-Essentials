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

namespace Oef11_2_PoolBall
{
    // Ronde entiteit
    public class Sphere
    {
        protected int x = 100;
        protected int y = 100;
        protected Pen pen = new Pen(Color.Black);

        public int X
        {
            set { x = value; }
        }

        public int Y
        {
            set { y = value; }
        }

        public virtual void Display(Graphics drawArea)
        {
            drawArea.DrawEllipse(pen, x, y, 20, 20);
        }
    }
}
