//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestVraag7_5
{
    public partial class Form1 : Form
    {
        private int loon = 0;
        private double belasting = 0;

        public Form1()
        {
            InitializeComponent();
            toonLoon();
            toonBelasting();
            salaryTrackBar.Scroll += HerberekenScroll;
        }

        private void HerberekenScroll(object sender, EventArgs e)
        {
            toonLoon();
            toonBelasting();
        }

        private void toonLoon()
        {
            loon = salaryTrackBar.Value;
            loonLabel.Text = String.Format("{0:c}", loon);
        }

        private void toonBelasting()
        {
            if (loon <= 10000)
            {
                belasting = 0;
            }
            if ((loon > 10000) && (loon <= 50000))
            {
                belasting = (loon - 10000) * 0.2;
            }
            if (loon > 50000)
            {
                belasting = 8000 + ((loon - 50000) * 0.9);
            }

            belastingLabel.Text = String.Format("{0:c}", belasting);
        }
    }
}
