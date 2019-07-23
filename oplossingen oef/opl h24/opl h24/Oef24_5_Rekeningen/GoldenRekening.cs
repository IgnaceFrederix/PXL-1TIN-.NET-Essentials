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
    public class GoldenRekening : Bankrekening
    {
        public GoldenRekening(double beginsaldo, string naam, string adres)
            : base(beginsaldo, naam, adres)
        { }

        public override double BerekenRente()
        {
            double rente = saldo * 0.06 - 100;
            return rente;
        }
    }
}
