//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef19_2_SomExamencijfers
{
    class Program
    {
        static void Main(string[] args)
        {
            int som = 0;

            Console.Write("Geef een uitslag: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            while (getal != -1)
            {
                som += getal;

                Console.Write("Geef een uitslag: ");
                getal = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Totaal: " + Convert.ToString(som));
        }
    }
}
