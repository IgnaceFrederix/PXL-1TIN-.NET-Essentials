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
    public abstract class Shape : IDisplayable
    {
        protected int x;
        protected int y;
        protected int size = 20;

        protected Pen myPen = new Pen(Color.Black);
        public abstract void Display(Graphics drawArea);
    }
}
