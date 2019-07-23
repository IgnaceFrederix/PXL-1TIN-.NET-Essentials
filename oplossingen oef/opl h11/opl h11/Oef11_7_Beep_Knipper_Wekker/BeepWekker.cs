//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace Oef11_7_Beep_Knipper_Wekker
{
    /// <summary>
    /// BeepWekker
    /// </summary>
    class BeepWekker : Wekker
    {
        public override void Go()
        {
            SystemSounds.Beep.Play();
        }
    }
}
