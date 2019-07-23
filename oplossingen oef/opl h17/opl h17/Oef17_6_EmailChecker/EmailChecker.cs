//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef17_6_EmailChecker
{
    public class EmailChecker
    {
        public string Email { get; set; }

        public void Check()
        {
            if (!(Email.Contains("@")))
            {
                throw new InvalidEmailException(Email + " bevat geen @-teken!");
            }
            // verdere controles kunnen hier ingebouwd worden.
        }
    }
}
