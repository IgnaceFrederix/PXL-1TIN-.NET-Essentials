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

namespace Swap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int a = 6;
            int b = 8;
            int c = 20;
            int d = 30;

            Swap(ref c, ref d);
            Swap(ref a, ref b);
            Swap(ref a, ref c);

            //int a = 3;
            //Swap(ref a, ref 6); 
        }

        private void Swap(ref int a, ref int b)
        {
            int aCopy;
            aCopy = a;
            a = b;
            b = aCopy;
        }
    }
}
