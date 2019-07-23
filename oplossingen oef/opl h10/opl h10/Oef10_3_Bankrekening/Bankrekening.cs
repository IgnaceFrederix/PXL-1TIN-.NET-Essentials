//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef10_3_Bankrekening
{
    public class Bankrekening
    {
        private int saldo;

        // Constructor
        public Bankrekening()
        {
            saldo = 0;
        }

        // Methodes
        public void Storting(int waarde)
        {
            saldo = saldo + waarde;
        }

        public void Opname(int waarde)
        {
            saldo = saldo - waarde;
        }

        // Property
        public int HuidigSaldo
        {
            get
            {
                return saldo;
            }
        }
    }
}
