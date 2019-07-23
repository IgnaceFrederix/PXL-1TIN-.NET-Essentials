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

namespace Oef20_3_CyberspaceInvaderExtended
{
    /// <summary>
    /// Verzameling van Alien objecten
    /// Deze verzameling wordt opgeslagen met een List
    /// </summary>
    /// <remarks>
    /// </remarks>
    public class Aliens
    {
        private List<Alien> alienList;

        private Score score;
        public Aliens(Score s)
        {
            alienList = new List<Alien>();
            score = s;
        }

        public void Add(Alien anAlien)
        {
            alienList.Add(anAlien);
        }

        public void Remove(Alien anAlien)
        {
            alienList.Remove(anAlien);
        }

        public void Move()
	    {
            foreach (Alien monster in alienList)
            {
                monster.Move();
            }
	    }

        public void Display(Graphics paper)
	    {
            foreach (Alien monster in alienList)
            {
                monster.Display(paper);
            }
	    }

        public void CheckHit(Lasers lasers)
        {
            int i = 0;
            while ((i < alienList.Count))
            {
                Alien monster = alienList[i];
                monster.CheckHit(lasers);
                if (monster.Dead)
                {
                    this.Remove(monster);
                    score.Increment();
                }
                i = i + 1;
            }
        }

        public bool AllDead()
        {
            return alienList.Count == 0;
        }

        public void Launch(Bombs bombs)
	    {
            foreach (Alien monster in alienList)
            {
                monster.Launch(bombs);
            }
	    }
    }

}
