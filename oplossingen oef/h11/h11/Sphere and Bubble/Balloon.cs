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
    public class Balloon
    {
        protected int xCoord, yCoord, radius;

        public Balloon()
        {
            xCoord = 10;
            yCoord = 10;
            radius = 20;
        }

        public Balloon(int initialX,
                       int initialY,
                       int initialRadius)
        {
            xCoord = initialX;
            yCoord = initialY;
            radius = initialRadius;
        }

        // remainder of the class
    }
}
