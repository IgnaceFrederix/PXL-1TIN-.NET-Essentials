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

namespace Oef11_1_Spaceship
{
    public class Ruimteschip
        : Balloon
    {
        protected int breedte;
        protected int hoogte;

        public int Breedte
        {
            set { breedte = value; }
        }

        public int Hoogte
        {
            set { hoogte = value; }
        }

        public override void Display(Graphics drawArea)
        {
            Pen pen = new Pen(Color.Black);
            drawArea.DrawEllipse(pen, x, y, breedte, hoogte);
        }
    }
}
