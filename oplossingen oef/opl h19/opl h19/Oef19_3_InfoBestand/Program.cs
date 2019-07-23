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

namespace Oef19_3_InfoBestand
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("gebruik: InfoBestand.exe <bestandsnaam>");
            }
            else
            {
                try
                {
                    FileStream stream = File.OpenRead(args[0]);
                    StreamReader reader = new StreamReader(stream);
                    string line = reader.ReadLine();

                    Console.WriteLine(line);
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
    }
}
