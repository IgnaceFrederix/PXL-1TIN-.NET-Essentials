//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef23_2_Bankrekening
{
    public interface IBankrekening
    {
        void Storting(int waarde);
        void Opname(int waarde);
        int Saldo { get; }
        string Naam { get; }
        string Nummer { get; }
    }
}
