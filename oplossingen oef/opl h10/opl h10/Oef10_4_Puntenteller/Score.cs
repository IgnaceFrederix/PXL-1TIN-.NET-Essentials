//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef10_4_Puntenteller
{
    public class Score
    {
        private int punten = 0;

        public int Punten
        {
            get { return punten; }
        }

        public void Reset()
        {
            punten = 0;
        }

        public void Increment()
        {
            punten++;
        }

        public void Decrement()
        {
            punten--;
        }
    }
}
