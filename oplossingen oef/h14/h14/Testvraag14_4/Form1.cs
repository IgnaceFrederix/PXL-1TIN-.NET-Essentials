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

namespace Testvraag14_4
{
    public partial class Form1 : Form
    {
        int[] demoarr = { 1, 2, 3, 4, 5 };
        
        public Form1()
        {
            InitializeComponent();
            Display(demoarr, textBox1);
        }

        public void Display(int[] array, TextBox outputTextBox)
        {
            outputTextBox.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                outputTextBox.AppendText(
                    Convert.ToString(array[i]));
                outputTextBox.AppendText(
                    Environment.NewLine);
            }
        }
    }
}
