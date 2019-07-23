//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef14_20_Dictionary
{
    public class Vak
    {
        public Vak(string naam, string docent, int uren)
        {
            Naam = naam;
            Docent = docent;
            Uren = uren;
        }

        public string Naam { get; set; }
        public string Docent { get; set; }
        public int Uren { get; set; }
    }
}
