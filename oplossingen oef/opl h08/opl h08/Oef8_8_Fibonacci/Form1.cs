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

namespace Oef8_8_Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int get1;
            int get2;
            int som = 0;
            get1 = 1;
            get2 = 1;
            resultTextBox.AppendText("1\r\n\r\n1\r\n\r\n");
            for (int i = 3; i <= 20; i++)
            {
                som = get1 + get2;
                resultTextBox.AppendText(som + "\r\n\r\n");
                get1 = get2;
                get2 = som;
            }
        }
    }
}
