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

namespace Complex_Conditions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Foo1()
        {
            const int maxSize = 100;
            int[] table = new int[maxSize];

            int wanted = Convert.ToInt32(wantedTextBox.Text);
            int index = 0;
            while ((index < maxSize) && (table[index] != wanted))
            {
                index++;
            }

            if (table[index] == wanted)
            {
                resultTextBox.Text = "Found";
            }
            else
            {
                resultTextBox.Text = "Not found";
            }
        }

        private void Foo2()
        {
            const int maxSize = 100;
            int[] table = new int[maxSize];

            int wanted = Convert.ToInt32(wantedTextBox.Text);

            const int stillSearching = 0;
            const int found = 1;
            const int notFound = 2;
            int state = stillSearching;
            
            int index = 0;
            while (state == stillSearching)
            {
                if (table[index] == wanted)
                {
                    state = found;
                }
                else if (index + 1 == maxSize)
                {
                    state = notFound;
                }
                index++;
            }

            if (state == found)
            {
                resultTextBox.Text = "Found";
            }
            else
            {
                resultTextBox.Text = "Not found";
            }
        }

        private void ifs1()
        {
            int a, b, c;
            int largest;

            if (a > b)
            {
                if (a > c)
                {
                    largest = a;
                }
                else
                {
                    largest = c;
                }
            }
            else
            {
                if (b > c)
                {
                    largest = b;
                }
                else
                {
                    largest = c;
                }
            }
        }

        private void ifs2()
        {
            int a, b, c;
            int largest;

            if ((a >= b) && (a >= c))
            {
                largest = a;
            }
            else if ((b >= a) && (b >= c))
            {
                largest = b;
            }
            else
            {
                largest = c;
            }
        }
    }
}
