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

namespace Oef14_15_Sorteren
{
    public partial class Form1 : Form
    {
        private int[] getallen = new int[100];
        private int vrijpos; // eerste vrije positie

        public Form1()
        {
            InitializeComponent();

            vrijpos = 0;
            getallenLabel.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            getallen[vrijpos] = Convert.ToInt32(getalTextBox.Text);
            vrijpos++;

            ToonGetallen();
        }

        private void ToonGetallen()
        {
            getallenLabel.Text = "";
            for (int i = 0; i < vrijpos; i++)
            {
                getallenLabel.Text += String.Format(" {0}", getallen[i]);
            }
        }

        private void Sorteer(int[] rij, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int kleinste_index = Kleinste(rij, i, n - 1);
                Swap(rij, i, kleinste_index);
            }
        }

        private int Kleinste(int[] rij, int startindex, int stopindex)
        {
            int kleinste_index = startindex;
            for (int i = startindex; i <= stopindex; i++)
            {
                if (rij[i] < rij[kleinste_index])
                    kleinste_index = i;
            }
            return kleinste_index;
        }

        private void Swap(int[] rij, int i, int j)
        {
            int temp = rij[i];
            rij[i] = rij[j];
            rij[j] = temp;
        }

        private void sorteerButton_Click(object sender, EventArgs e)
        {
            Sorteer(getallen, vrijpos);
            ToonGetallen();
        }
    }
}
