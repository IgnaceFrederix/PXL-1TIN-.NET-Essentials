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

namespace Love
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //IndexOutOfRangeException
            //int[] table = new int[10];
            //for (int i = 0; i <= 10; i++)
            //{
            //    table[i] = 0;
            //}


            //NullReferenceException
            //Random ageGuesser = new Random();
            //ageGuesser = null;
            //int age = ageGuesser.Next(5, 110);

            //string temp = leftTextBox.Text;

            //rightTextBox.Text = temp;
        }

        private void swapButton_Click(object sender, EventArgs e)
        {   
            leftTextBox.Text = rightTextBox.Text;
            rightTextBox.Text = leftTextBox.Text;
        }
    }
}
