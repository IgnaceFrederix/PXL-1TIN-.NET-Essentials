//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef23_3_CyberspaceInvader
{
    public interface ISprite
    {
        int X { get; }
        int Y { get; }
        int Width { get; }
        int Height { get; }
    }
}
