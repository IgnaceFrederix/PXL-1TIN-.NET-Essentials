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

namespace Lussen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            numbersTextBox.Clear();
            while (count <= 9)
            {
                numbersTextBox.AppendText(count + " ");
                count++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numbersTextBox.Clear();
            for (int count = 0; count <= 9; count++)
            {
                 numbersTextBox.AppendText(count + " ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            numbersTextBox.Clear();
            do
            {
                numbersTextBox.AppendText(count + " ");
                count++;
            } while (count <= 9);
        }
    }
}