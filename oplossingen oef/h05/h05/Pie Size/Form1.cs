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

namespace Pie_Size
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pieWidth = 8, pieLength = 6;
            IncreaseSize(ref pieWidth, ref pieLength);
            IncreaseSize(ref pieWidth, ref pieLength);
            IncreaseSize(ref pieWidth, ref pieLength);
        }

        private void IncreaseSize(ref int width, ref int length)
        {
            int area;
            width = width + 2;
            length = length + 2;
            area = width * length;
            string message = String.Format("Pie size: {0} by {1}. Area is {2}",
                                           width, length, area);
            MessageBox.Show(message);
        }
    }
}
