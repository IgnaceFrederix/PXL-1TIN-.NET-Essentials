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

namespace Sphere_and_Bubble
{
    public abstract class Shape
    {
        protected int xCoord, yCoord;
        protected int size;
        protected Pen pen = new Pen(Color.Black);

        public void MoveRight()
        {
            xCoord += 10;
        }

        public abstract void Display(Graphics drawArea);
    }
}
