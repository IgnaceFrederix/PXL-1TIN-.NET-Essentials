//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vormen
{
    public class Kubus
         : Vierkant
    {
        public Kubus(int z)
            : base(z)
        { }

        public override int Oppervlakte()
        {
            return base.Oppervlakte() * 6;
        }
    }
}
