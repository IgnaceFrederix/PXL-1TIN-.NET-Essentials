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

namespace Oef15_6_KunstmatigLeven
{
    public partial class Form1 : Form
    {
        // index van de huidige rij die je aan het invullen bent
        private int rij;
        // dimensie van de matrix
        private int aKolommen;
        // index van de eerste levende cel
        private int eersteCel;
        // geeft aan of het spel al gestart is
        private bool gestart;

        private string[,] matrix;

        public Form1()
        {
            InitializeComponent();

            rij = 0;
            gestart = false;
        }
        
        private void volgendeButton_Click(System.Object sender, System.EventArgs e)
        {
            if (!gestart)
            {
                aKolommen = Convert.ToInt32(aantalTextBox.Text);
                matrix = new string[aKolommen + 2, aKolommen + 2];
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    matrix[rij, i] = " ";
                }

                // de eerste kolom is een sentinel, dus eentje bijtellen
                eersteCel = Convert.ToInt32(eersteTextBox.Text);
                matrix[rij, eersteCel + 1] = "*";
                printMatrix();
                gestart = true;
                rij = rij + 1;
            }
            else
            {
                if (rij < matrix.GetLength(0))
                {
                    berekenVolgendeRij();
                    printMatrix();
                    rij = rij + 1;
                }
                else
                {
                    MessageBox.Show("Game Over");
                    rij = 0;
                    gestart = false;
                }
            }
        }

        private void printMatrix()
        {
            lifeTextBox.Clear();

            for (int index = 0; index <= rij; index++)
            {
                for (int i = 1; i < matrix.GetLength(1) -1; i++)
                {
                    lifeTextBox.AppendText("|");
                    lifeTextBox.AppendText(matrix[index, i]);
                }
                lifeTextBox.AppendText("|");
                lifeTextBox.AppendText(Environment.NewLine);
            }
        }

        private void berekenVolgendeRij()
        {
            // de sentinelcellen zijn per definitie dood
            matrix[rij, 0] = " ";
            matrix[rij, matrix.GetLength(1) - 1] = " ";
            // Bereken enkel de echte cellen en niet de sentinel-cellen
            for (int i = 1; i < matrix.GetLength(1) - 1; i++)
            {
                matrix[rij, i] = " ";
                // cel was dood, maar alleen linkerbuurman levend
                if (((matrix[rij - 1, i] == " ") && (matrix[rij - 1, i - 1] == "*") && (matrix[rij - 1, i + 1] == " ")))
                {
                    matrix[rij, i] = "*";
                }
                // cel was dood, maar alleen zijn rechterbuurman levend
                if (((matrix[rij - 1, i] == " ") && (matrix[rij - 1, i - 1] == " ") && (matrix[rij - 1, i + 1] == "*")))
                {
                    matrix[rij, i] = "*";
                }
                // cel was levend, maar beide buren dood
                if (((matrix[rij - 1, i] == "*") & (matrix[rij - 1, i - 1] == " ") & (matrix[rij - 1, i + 1] == " ")))
                {
                    matrix[rij, i] = "*";
                }
                // cel was levend, maar alleen zijn rechterbuurman levend
                if (((matrix[rij - 1, i] == "*") & (matrix[rij - 1, i - 1] == " ") & (matrix[rij - 1, i + 1] == "*")))
                {
                    matrix[rij, i] = "*";
                }
            }
        }
    }
}
