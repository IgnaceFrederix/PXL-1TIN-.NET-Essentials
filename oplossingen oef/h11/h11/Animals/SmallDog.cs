//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public sealed class SmallDog : Dog
    {
        public SmallDog(string name)
            : base(name)
        {}

        public override string Sound()
        {
            return "Kef Kef";
        }

    }
}
