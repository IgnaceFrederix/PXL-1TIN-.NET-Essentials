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
    public class Vierkant
    {
        protected int zijde;

        public Vierkant(int z)
        {
            this.zijde = z;
        }

        public virtual int Oppervlakte()
        {
            return zijde * zijde;
        }
    }
}
