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

namespace Testvraag5_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Calls();
        }

        private int Twice(int n)
        {
            return 2 * n;
        }

        private void Calls()
        {
            int n = 3;
            int r;
            r = Twice(n);
            Toon(r);
            r = Twice(n + 1);
            Toon(r);
            r = Twice(n) + 1;
            Toon(r);
            r = Twice(3 + 2 * n);
            Toon(r);
            r = Twice(Twice(n));
            Toon(r);
            r = Twice(Twice(n + 1));
            Toon(r);
            r = Twice(Twice(n) + 1);
            Toon(r);
            r = Twice(Twice(Twice(n)));
            Toon(r);
        }

        private void Toon(int n)
        {
            MessageBox.Show(String.Format("n = {0}", n));
        }
    }
}
