//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef11_2_PoolBall
{
    // een vrij beweegbare ronde entiteit
    public class Ball : Sphere
    {
        public virtual void MoveLeft(int amount)
        {
            x -= amount;
        }

        public virtual void MoveRight(int amount)
        {
            x += amount;
        }

        public virtual void MoveUp(int amount)
        {
            y -= amount;
        }

        public virtual void MoveDown(int amount)
        {
            y += amount;
        }
    }
}
