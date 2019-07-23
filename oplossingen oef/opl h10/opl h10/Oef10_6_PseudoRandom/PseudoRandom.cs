//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef10_6_PseudoRandom
{
    public class PseudoRandom
    {
        private int seed;

        public PseudoRandom()
        {
            seed = 0;
        }

        public PseudoRandom(int s)
        {
            seed = s;
        }

        public int NextInt()
        {
            int nextR = (((seed * 25173) + 13849) % 65536);
            seed = nextR;
            return nextR;
        }
    }
}
