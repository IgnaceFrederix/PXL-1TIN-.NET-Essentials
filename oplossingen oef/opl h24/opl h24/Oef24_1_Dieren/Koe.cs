//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef24_1_Dieren
{
    public class Koe : Dier
    {
        public override string Zegt()
        {
            return "Boe";
        }

        public override string ToString()
        {
            return "Koe: " + base.ToString();
        }
    }
}
