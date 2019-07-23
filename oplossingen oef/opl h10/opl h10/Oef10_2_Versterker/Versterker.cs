//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef10_2_Versterker
{
    public class Versterker
    {
        private int min;
        private int max;

        public Versterker(int waarde)
        {
            min = waarde;
            max = waarde;
        }

        public void NieuweWaarde(int volume)
        {
            if (volume > max)
            {
                max = volume;
            }
            if (volume < min)
            {
                min = volume;
            }
        }

        public int KleinsteWaarde
        {
            get { return min; }
        }

        public int GrootsteWaarde
        {
            get { return max; }
        }
    }
}
