//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sphere_and_Bubble
{
    public class Ball : Sphere
    {
        public void MoveLeft(int amount)
        {
            xCoord -= amount;
        }

        public void MoveRight(int amount)
        {
            xCoord += amount;
        }
    }
}
