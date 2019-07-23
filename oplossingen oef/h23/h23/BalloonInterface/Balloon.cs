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
    public class Balloon : IBalloon
    {
        private int diameter;
        private int x, y;

        public void ChangeSize(int diameter)
        {
            this.diameter = diameter;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public void Display(Graphics drawArea)
        {
            Pen pen = new Pen(Color.Black);
            drawArea.DrawEllipse(pen, x, y, diameter, diameter);
        }
    }
}
