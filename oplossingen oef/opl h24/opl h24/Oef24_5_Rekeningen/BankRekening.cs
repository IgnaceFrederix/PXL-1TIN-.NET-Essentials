//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef24_5_Rekeningen
{
    public abstract class Bankrekening
    {
        protected double saldo;
        private string naam;
        private string adres;

        public Bankrekening(double beginsaldo, string naam, string adres)
        {
            this.saldo = beginsaldo;
            this.naam = naam;
            this.adres = adres;
        }

        //Methodes
        public void DebetSaldo(int waarde)
        {
            saldo += waarde;
        }

        public virtual void CreditSaldo(int waarde)
        {
            saldo -= waarde;
        }

        public abstract double BerekenRente();

        //Property
        public double HuidigSaldo
        {
            get { return saldo; }
        }

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
    }
}
