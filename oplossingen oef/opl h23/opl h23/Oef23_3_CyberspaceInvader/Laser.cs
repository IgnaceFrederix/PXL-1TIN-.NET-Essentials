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

namespace Oef23_3_CyberspaceInvader
{
    public class Laser : Sprite, ILaser
    {
        private int stepSize;
        private Lasers lasers;

        public Laser(int x, int y, Lasers lasers)
        {
            X = x;
            Y = y;
            Width = 5;
            Height = 5;
            stepSize = 1;
            this.lasers = lasers;
            lasers.Add(this);
        }

        public void Display(Graphics paper)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            paper.FillEllipse(brush, X, Y, Width, Height);
        }

        public void Move()
        {
            if (Y < 10)
            {
                lasers.Remove(this);
            }
            else
            {
                Y -= stepSize;
            }
        }

        public void CheckHit(IAlien alien)
        {
            if ((X > alien.X) &&
                (Y < (alien.Y + alien.Height)) &&
                (X + Width) < (alien.X + alien.Width) &&
                (Y + Height) > (alien.Y))
            {
                alien.Dead = true;
                lasers.Remove(this);
            }
        }
    }
}
