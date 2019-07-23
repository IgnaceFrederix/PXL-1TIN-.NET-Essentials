//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef11_3_Bankrekeningen
{
    public abstract class Bankrekening
    {
        protected double saldo;

        public void DebetSaldo(double waarde)
        {
            saldo += waarde;
        }

        public void CreditSaldo(double waarde)
        {
            saldo -= waarde;
        }

        public abstract double BerekenRente();

        public double Saldo
        {
            get { return saldo; }
        }
    }
}
