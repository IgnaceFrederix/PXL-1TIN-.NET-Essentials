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

namespace Oef11_1_Spaceship
{
    public class Balloon
    {
        protected int x = 50;
        protected int y = 50;
        private int diameter = 20;

        public void MoveRight(int xStep)
        {
            x += xStep;
        }

        public void ChangeSize(int change)
        {
            diameter += change;
        }

        public virtual void Display(Graphics drawArea)
        {
            Pen pen = new Pen(Color.Black);
            drawArea.DrawEllipse(pen, x, y, diameter, diameter);
        }
    }
}
