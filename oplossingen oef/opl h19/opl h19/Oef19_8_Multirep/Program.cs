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

namespace Oef19_8_Multirep
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: Multirep.exe <bestand> <van/naar bestand>");
            }
            else
            {
                try
                {
                    StreamReader inStream = new StreamReader(args[0]);
                    string content = inStream.ReadToEnd();
                    inStream.Close();

                    inStream = new StreamReader(args[1]);
                    while (inStream.Peek() >= 0)
                    {
                        string van = inStream.ReadLine();
                        string naar = inStream.ReadLine();

                        content = Change(content, van, naar);
                    }
                    inStream.Close();

                    Console.WriteLine(content);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("bestand bestaat niet");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                }

            }
        }

        static string Change(string original, string fromText, string toText)
        {
            string leftBit = null;
            string rightBit = null;
            int startSearch = 0;
            int place = original.IndexOf(fromText);

            if (fromText.Length != 0)
            {
                while (place >= startSearch)
                {
                    leftBit = original.Substring(0, place);
                    rightBit = original.Substring(place + fromText.Length, original.Length - place - fromText.Length);

                    original = leftBit + toText + rightBit;
                    startSearch = leftBit.Length + toText.Length;
                    place = original.IndexOf(fromText);
                }
            }
            return original;
        }
    }
}
