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

namespace Oef19_7_ReplaceString
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("ReplaceString.exe <bestand> <oud woord> <nieuw woord>");
            }
            else
            {
                try
                {
                    StreamReader inStream = new StreamReader(args[0]);
                    string content = inStream.ReadToEnd();
                    inStream.Close();

                    content = Change(content, args[1], args[2]);
                    string parent = Directory.GetParent(args[0]).FullName;
                    string dest = Path.Combine(parent, "output.txt");
                    StreamWriter outStream = new StreamWriter(dest);
                    outStream.Write(content);
                    outStream.Close();
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
