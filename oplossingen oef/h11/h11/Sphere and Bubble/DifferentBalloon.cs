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
    public class DifferentBalloon : Balloon
    {
        public DifferentBalloon(int initialX,
                                int initialY) : base()
        {
            xCoord = initialX;
            yCoord = initialY;
            radius = 20;
        }

        // remainder of the class
    }
}
