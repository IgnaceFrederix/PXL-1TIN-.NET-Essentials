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
    public interface IAlien : ISprite
    {
        void Display(Graphics paper);
        void Move();
        void CheckHit(Lasers lasers);
        void Destroy();
        bool Dead { get; set; }
        void Launch(Bombs bombs);
    }
}
