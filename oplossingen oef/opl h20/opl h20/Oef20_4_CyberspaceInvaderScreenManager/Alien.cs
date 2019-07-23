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

namespace Oef20_4_CyberspaceInvaderScreenManager
{
    public class Alien : Sprite
    {
        private int stepSize;
        private PictureBox alienImage;

        public bool Dead { get; set; }

        public Alien(PictureBox initialAlienImage)
        {
            X = 100;
            Y = 50;
            Width = 25;
            Height = 25;
            alienImage = initialAlienImage;
            stepSize = 1;
            Dead = false;
        }

        public void Display(Graphics paper)
        {
            Image image = alienImage.Image;
            paper.DrawImage(image, X, Y, Width, Height);
        }

        public void Move()
        {
            if ((X > 250) || (X < 0))
            {
                stepSize = -stepSize;
            }
            X += stepSize;
        }

        public void CheckHit(Lasers lasers)
        {
            lasers.CheckHit(this);
        }

        public void Launch(Bombs bombs)
        {
            Bomb bomb = new Bomb(X + (Width / 2), Y + Height, bombs);
        }
    }
}
