//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef17_7_Bankrekening
{
    public class Bankrekening
    {
        public int Saldo { get; set; }
        public string Nummer { get; set; }
        public string Naam { get; set; }

        public Bankrekening(string nummer, string naam)
        {
            Saldo = 0;
            Nummer = nummer;
            Naam = naam;
        }

        public void Storting(int waarde)
        {
            if (waarde > 2500)
            {
                throw new BankException("Storting kan maximaal 2500 bedragen.");
            }
            Saldo += waarde;
        }

        public void Opname(int waarde)
        {
            if ((Saldo - waarde) < 0)
            {
                throw new BankException(String.Format("Saldo ontoereikend: {0}", Saldo));
            }
            Saldo -= waarde;
        }
    }
}
