//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Oef20_2_CyberspaceInvader
{
    public class Bomb : Sprite
    {
        private int stepSize;
        private Bombs bombs;

        public Bomb(int initialX, int initialY, Bombs bombs)
        {
            X = initialX;
            Y = initialY;
            Width = 5;
            Height = 5;
            stepSize = 1;
            this.bombs = bombs;
            bombs.Add(this);
        }

        public void Display(Graphics paper)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            paper.FillEllipse(brush, X, Y, Width, Height);
        }

        public void Move()
        {
            if (Y > 250)
            {
                bombs.Remove(this);
            }
            else
            {
                Y += stepSize;
            }
        }

        public void CheckHit(User user)
        {
            if ((X > user.X) &&
                (Y < (user.Y + user.Height)) &&
                ((X + Width) < (user.X + user.Width)) &&
                ((Y + Width) > (user.Y)))
            {
                bombs.Remove(this);
                user.Dead = true;
            }
        }
    }
}
