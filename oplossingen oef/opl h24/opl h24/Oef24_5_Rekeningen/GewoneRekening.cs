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
    public class GewoneRekening : Bankrekening
    {
        public GewoneRekening(double beginsaldo, string naam, string adres)
            : base(beginsaldo, naam, adres)
        { }

        public override void CreditSaldo(int waarde)
        {
            if ((HuidigSaldo - waarde) < 0)
            {
                throw new BankException("Negatief saldo niet toegestaan voor gewone rekening");
            }
            base.CreditSaldo(waarde);
        }

        public override double BerekenRente()
        {
            double rente = HuidigSaldo * 0.05;
            return rente;
        }
    }
}
