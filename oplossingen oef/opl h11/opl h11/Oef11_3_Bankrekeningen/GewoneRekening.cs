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
    public class GewoneRekening : Bankrekening
    {
        public override double BerekenRente()
        {
            double rente = 0.0;

            if (saldo > 100.0)
                rente = (saldo - 100) * 0.01;

            return rente;
        }
    }
}
