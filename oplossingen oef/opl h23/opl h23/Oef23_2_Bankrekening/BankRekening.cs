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
    public class Bankrekening : IBankrekening
    {
        private int saldo;
        private string nummer;

        private string naam;
        //Constructor
        public Bankrekening(string nummer, string naam)
        {
            saldo = 0;
            this.nummer = nummer;
            this.naam = naam;
        }

        //Methodes
        public void Storting(int waarde)
        {
            if (waarde > 2500)
            {
                throw new BankException("Storting kan maximaal 2500 bedragen");
            }
            saldo += waarde;
        }

        public void Opname(int waarde)
        {
            if (saldo - waarde < 0)
            {
                throw new BankException("Saldo ontoereikend: " + Convert.ToString(saldo));
            }
            saldo -= waarde;
        }

        //Property
        public int Saldo
        {
            get { return saldo; }
        }

        public string Naam
        {
            get { return naam; }
        }

        public string Nummer
        {
            get { return nummer; }
        }
    }
}
