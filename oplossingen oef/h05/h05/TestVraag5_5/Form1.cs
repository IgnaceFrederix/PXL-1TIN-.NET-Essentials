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

namespace TestVraag5_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int a = 3;
            int b = 8;
            DoStuff(a, b);
            MessageBox.Show(Convert.ToString(a));
        }

        private void DoStuff(int x, int y)
        {
            int a = 0;
            a = x + y;
        }
    }
}
