//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef19_1_DubbeleWaarde
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Origineel getal: " + Convert.ToString(getal));
            Console.WriteLine("Dubbel: " + Convert.ToString(getal * 2));
        }
    }
}
