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
    public class GoldenRekening : Bankrekening
    {
        public override double BerekenRente()
        {
            return saldo * 0.1;
        }
    }
}
