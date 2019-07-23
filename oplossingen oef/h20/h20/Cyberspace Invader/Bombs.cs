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

namespace Cyberspace_Invader
{
    public class Bombs
    {
        private List<Bomb> bombList = new List<Bomb>();

        public void Add(Bomb bomb)
        {
            bombList.Add(bomb);
        }

        public void Remove(Bomb bomb)
        {
            bombList.Remove(bomb);
        }

        public void Display(Graphics paper)
        {
            for (int i = 0; i < bombList.Count; i++)
            {
                bombList[i].Display(paper);
            }
        }

        public void Move()
        {
            for (int i = 0; i < bombList.Count; i++)
            {
                bombList[i].Move();
            }
        }

        public void CheckHit(User user)
        {
            for (int i = 0; i < bombList.Count; i++)
            {
                bombList[i].CheckHit(user);
            }
        }
    }
}
