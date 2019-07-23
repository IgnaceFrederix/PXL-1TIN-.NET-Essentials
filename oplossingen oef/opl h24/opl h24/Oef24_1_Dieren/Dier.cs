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
    public abstract class Dier
    {
        public Dier()
        {
            Gewicht = 0;
        }
        
        public int Gewicht { get; set; }
        public abstract string Zegt();

        public override string ToString()
        {
            return String.Format("{0}, {1}", Gewicht, Zegt());
        }
    }
}
