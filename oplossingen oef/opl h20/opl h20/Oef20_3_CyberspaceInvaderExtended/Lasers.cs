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
    public class Lasers
    {
        private List<Laser> laserList = new List<Laser>();

        public void Add(Laser laser)
        {
            laserList.Add(laser);
        }

        public void Remove(Laser laser)
        {
            laserList.Remove(laser);
        }

        public void Display(Graphics paper)
        {
            for (int i = 0; i < laserList.Count; i++)
            {
                laserList[i].Display(paper);
            }
        }

        public void Move()
        {
            for (int i = 0; i < laserList.Count; i++)
            {
                laserList[i].Move();
            }
        }

        public void CheckHit(Alien alien)
        {
            for (int i = 0; i < laserList.Count; i++)
            {
                laserList[i].CheckHit(alien);
            }
        }

        public void CheckHit(Wall wall)
        {
            for (int i = 0; i < laserList.Count; i++)
            {
                laserList[i].CheckHit(wall);
            }
        }
    }
}
