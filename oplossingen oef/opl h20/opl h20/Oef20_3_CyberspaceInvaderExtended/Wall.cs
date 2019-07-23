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

namespace Oef20_3_CyberspaceInvaderExtended
{
    public class Wall : Sprite
    {
        private Color color;
        private SolidBrush myBrush;

        public Wall(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
            Width = 80;
            Height = 5;
            color = Color.BurlyWood;
            myBrush = new SolidBrush(color);
        }

        public void Display(Graphics paper)
        {
            paper.FillRectangle(myBrush, X, Y, Width, Height);
        }
    }
}
