//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Oef20_3_CyberspaceInvaderExtended
{
    public class Score
    {
        private int value;

        private Label display;
        public Score(Label l)
        {
            value = 0;
            display = l;
            display.Text = Convert.ToString(value);
        }

        public void Increment()
        {
            value = value + 1;
            display.Text = Convert.ToString(value);
        }
    }
}
