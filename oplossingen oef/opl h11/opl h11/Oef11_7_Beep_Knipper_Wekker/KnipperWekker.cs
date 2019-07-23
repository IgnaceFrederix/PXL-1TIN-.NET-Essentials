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
using System.Drawing;

namespace Oef11_7_Beep_Knipper_Wekker
{
    /// <summary>
    /// KnipperWekker
    /// </summary>
    class KnipperWekker : Wekker
    {
        private Form myForm;
        private Color color1;
        private Color color2;

        public KnipperWekker(Form f)
        {
            myForm = f;
            color1 = myForm.BackColor;
            color2 = Color.Tomato;
        }

        public override void Reset()
        {
            base.Reset();
            myForm.BackColor = color1;
        }

        public override void Go()
        {
            if (myForm.BackColor == color1)
            {
                myForm.BackColor = color2;
            }
            else
            {
                myForm.BackColor = color1;
            }
        }
    }
}
