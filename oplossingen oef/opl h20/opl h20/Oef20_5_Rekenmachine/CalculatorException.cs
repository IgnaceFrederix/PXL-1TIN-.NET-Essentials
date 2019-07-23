//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef20_5_Rekenmachine
{
    public class CalculatorException : ApplicationException
    {
        public CalculatorException(string msg)
            : base(msg)
        {
        }
    }
}
