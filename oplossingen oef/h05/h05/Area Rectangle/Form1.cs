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

namespace Area_Rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = AreaRectangle(10, 20);
        }

        private int AreaRectangle(int length, int width)
        {
            int area;
            area = length * width;
            return area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            n = AreaRectangle(10, 20);
            MessageBox.Show("Area is " + AreaRectangle(3, 4));
            n = AreaRectangle(10, 20) * AreaRectangle(7, 8);
        }

        private int AreaRectangle2(int length, int width)
        {
            return length * width;
        }
    }
}
