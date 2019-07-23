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
    public class User : Sprite
    {
        private int stepSize;
        private PictureBox userImage;

        public bool Dead { get; set; }

        public User(PictureBox initialUserImage)
        {
            X = 0;
            Y = 225;
            Width = 20;
            Height = 20;
            userImage = initialUserImage;
            stepSize = 1;
            Dead = false;
        }

        public void Display(Graphics paper)
        {
            Image image = userImage.Image;
            paper.DrawImage(image, X, Y, Width, Height);
        }

        public void Move(int x)
        {
            X = x;
        }
    }
}
