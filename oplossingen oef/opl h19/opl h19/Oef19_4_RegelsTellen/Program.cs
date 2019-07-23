//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Oef19_4_RegelsTellen
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("gebruik: RegelsTellen.exe <bestandsnaam>");
            }
            else
            {
                try
                {
                    Console.WriteLine(AantalRegels(args[0]));
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("bestand bestaat niet");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("FOUT: " + ex.Message);
                }
            }
        }

        private static int AantalRegels(string bestand)
        {
            FileStream stream = File.OpenRead(bestand);
            StreamReader reader = new StreamReader(stream);
            int aantal = 0;
            string line = "";

            while (reader.Peek() >= 0)
            {
                line = reader.ReadLine();
                aantal += 1;
            }

            return aantal;
        }
    }
}
