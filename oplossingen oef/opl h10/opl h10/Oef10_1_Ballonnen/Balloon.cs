//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Oef10_1_Ballonnen
{
    public class Balloon
    {
        private int x = 50;
        private int y = 50;
        private int diameter = 20;
        private string naam;
        private string kleur;
        private Pen pen = new Pen(Color.Black);

        public Balloon(string naam,
                       string kleur)
        {
            this.naam = naam;
            this.kleur = kleur;
        }

        public void MoveRight(int xStep)
        {
            x = x + xStep;
        }

        public void MoveLeft(int xStep)
        {
            x = x - xStep;
        }

        public void MoveUp(int yStep)
        {
            y = y - yStep;
        }

        public void MoveDown(int yStep)
        {
            y = y + yStep;
        }

        public void ChangeSize(int change)
        {
            diameter = diameter + change;
        }

        public void Display(Graphics drawArea)
        {
            drawArea.DrawEllipse(pen, x, y, diameter, diameter);
        }

        public string GeefKleurEnNaam()
        {
            return String.Format("Ballon met naam = {0} en kleur = {1}",
                                  naam, kleur);
        }
    }
}
