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

namespace Oef23_3_CyberspaceInvader
{
    public class Bombs
    {
        private List<IBomb> bombList = new List<IBomb>();

        public void Add(IBomb bomb)
        {
            bombList.Add(bomb);
        }

        public void Remove(IBomb bomb)
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

        public void CheckHit(IUser user)
        {
            for (int i = 0; i < bombList.Count; i++)
            {
                bombList[i].CheckHit(user);
            }
        }
    }
}
