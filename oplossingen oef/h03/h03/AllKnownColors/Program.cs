//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace AllKnownColors
{
    class Program
    {
        static void Main(string[] args)
        {
            var props = typeof(Color).GetProperties(BindingFlags.Public | BindingFlags.Static);
            foreach (PropertyInfo prop in props)
            {
                Color color = (Color)prop.GetValue(null, null);
                Console.WriteLine("Color.{0} = ({1}, {2}, {3})", prop.Name,
                                  color.R, color.G, color.B);
            }
            Console.WriteLine();
            Console.WriteLine("Aantal kleuren: " + props.Length);
        }
    }
}
