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

namespace Oef19_6_ToonBeknopt
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Usage();
            }
            else
            {
                ToonBestand(args[0], args[1]);
            }
        }

        static void Usage()
        {
            Console.WriteLine("usage: beknopt.exe <bestand> <patroon>");
        }

        static void ToonBestand(string best, string zoekwoord)
        {
            StreamReader reader = null;
            string line = null;

            try
            {
                reader = File.OpenText(best);
                while (reader.Peek() >= 0)
                {
                    line = reader.ReadLine();
                    if (!(line.Contains(zoekwoord)))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            finally
            {
                if ((reader != null))
                {
                    reader.Close();
                }
            }
        }
    }
}
