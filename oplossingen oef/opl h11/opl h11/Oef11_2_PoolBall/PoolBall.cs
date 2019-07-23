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
    // een beperkt beweegbare ronde entiteit
    public class PoolBall : Ball
    {
        private int boundWidth;
        private int boundHeight;

        // Markeer grenzen waarbinnen de bal moet blijven
        public PoolBall(int w, int h)
        {
            boundWidth = w;
            boundHeight = h;
        }

        public override void MoveDown(int amount)
        {
            if ((y + amount) <= (boundHeight - 20))
            {
                base.MoveDown(amount);
            }
            else if (((y + amount) > (boundHeight - 20)) &&
                     ((y + amount) < boundHeight))
            {
                y = boundHeight - 20;
            }
            else if ((y + amount) >= boundHeight)
            {
                int z = y + amount - boundHeight;
                y = boundHeight - z - 20;
            }
        }

        public override void MoveUp(int amount)
        {
            if ((y - amount) < 0)
            {
                int z = amount - y;
                y = z;
            }
            else
            {
                base.MoveUp(amount);
            }
        }

        public override void MoveLeft(int amount)
        {
            if ((x - amount) < 0)
            {
                int z = amount - x;
                x = z;
            }
            else
            {
                base.MoveLeft(amount);
            }
        }

        public override void MoveRight(int amount)
        {
            if ((x + amount) <= (boundWidth - 20))
            {
                base.MoveRight(amount);
            }
            else if (((x + amount) > (boundWidth - 20)) &&
                     ((x + amount) < boundWidth))
            {
                x = boundWidth - 20;
            }
            else if ((x + amount) >= boundWidth)
            {
                int z = x + amount - boundWidth;
                x = boundWidth - z - 20;
            }
        }
    }
}
