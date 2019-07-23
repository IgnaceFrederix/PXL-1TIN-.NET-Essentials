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

namespace TestVraag4_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result;

            int i, j, k;
            double a, b, c;
            int x = 3;
            double y = 2.7;

            i = (int)y;
            j = (int)(y + 0.6);
            k = Convert.ToInt32(x + 0.6);

            a = x;
            b = (int)y;
            c = (double)y;

            result = String.Format("a = {0:0.0}\r\nb = {1:0.0}\r\nc = {2:0.0}\r\ni = {3}\r\nj = {4}\r\nk = {5}", a, b, c, i, j, k);
            textBox1.Text = result;
        }
    }
}
