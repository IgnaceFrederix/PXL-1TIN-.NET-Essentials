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

namespace Oef14_5_StringArray
{
    public partial class Form1 : Form
    {
        private string[] words = new string[10];

        public Form1()
        {
            InitializeComponent();

            Display();
        }

        private void  insertButton_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(posTextBox.Text);

            if ((index >= 0) & (index < words.Length))
            {
                words[index] = valTextBox.Text;
            }
            Display();
        }

        private void Display()
        {
            resultsTextBox.Text = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                resultsTextBox.AppendText(String.Format("{0}\t{1}\r\n", i, (words[i] == null ? "Nothing" : words[i])));
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int index = Zoek(searchTextBox.Text, words);
            if (index == -1)
            {
                MessageBox.Show("Woord niet gevonden");
            }
            else
            {
                MessageBox.Show("gevonden op positie " + Convert.ToString(index));
            }

        }

        private int Zoek(string woord, string[] rij)
        {
            int i = 0;
            
            while (i < rij.Length)
            {
                if (rij[i] == woord)
                {
                    return i;
                }
                i = i + 1;
            }
            return -1;
        }
    }
}
