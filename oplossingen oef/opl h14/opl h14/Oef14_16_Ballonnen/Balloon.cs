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

namespace Oef14_16_Ballonnen
{
    public class Balloon
    {
        private int x;
        private int y;

        private int diameter;
        
        public Balloon(int initialX, int initialY, int initialDiameter)
            : base()
        {
            x = initialX;
            y = initialY;
            diameter = initialDiameter;
        }

        public void ChangeSize(int change)
        {
            diameter = diameter + change;
        }

        public void Display(Graphics drawArea, Pen myPen)
        {
            drawArea.DrawEllipse(myPen, x, y, diameter, diameter);
        }

        public void MoveHorizontal(int dx)
        {
            x = x + dx;
        }
    }
}
