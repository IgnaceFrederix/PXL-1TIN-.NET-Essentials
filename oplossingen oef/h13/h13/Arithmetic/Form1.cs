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

namespace Arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            numberListBox.Items.Add(numberTextBox.Text);
        }

        private void sumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int number;
            for (int index = 0; index < numberListBox.Items.Count; index++)
            {
                number = Convert.ToInt32(numberListBox.Items[index]);
                sum += number;
            }
            sumTextBox.Text = Convert.ToString(sum);
        }

        private void largestButton_Click(object sender, EventArgs e)
        {
            int largest = Convert.ToInt32(numberListBox.Items[0]);
            int number;
            for (int index = 1; index < numberListBox.Items.Count; index++)
            {
                number = Convert.ToInt32(numberListBox.Items[index]);
                if (number > largest)
                {
                    largest = number;
                }
            }
            largestTextBox.Text = Convert.ToString(largest);
        }

        // alternatief met foreach
        //private void sumButton_Click(object sender, EventArgs e)
        //{
        //    int sum = 0;
        //    foreach (string number in numberListBox.Items)
        //    {
        //        sum += Convert.ToInt32(number);
        //    }
        //    sumTextBox.Text = Convert.ToString(sum);
        //}

    }
}
