//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef17_9_BankRekeningMetErrorProvider
{
    public class BankException
        : ApplicationException
    {
        public BankException(string message)
            : base(message)
        { }
    }
}
