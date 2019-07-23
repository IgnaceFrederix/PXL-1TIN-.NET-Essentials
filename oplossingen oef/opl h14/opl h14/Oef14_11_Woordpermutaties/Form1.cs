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

namespace Oef14_11_Woordpermutaties
{
    /// <summary>
    /// Deze oplossing is gestructureerd rond volgende redenering. Stel dat je moet permuteren de woorden A B en C.
    /// De permutaties van A en B is gemakkelijk, namelijk:
    /// A B
    /// B A
    /// Voor de drie woorden schrijf je de permutatie van twee woorden driemaal uit:
    /// A B
    /// B A
    /// 
    /// A B
    /// B A
    /// 
    /// A B
    /// B A
    /// 
    /// En vervolgens "weef" je woord C erin als volgt:
    /// 
    /// C A B
    /// C B A
    /// 
    /// A C B
    /// B C A
    /// 
    /// A B C
    /// B A C
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void permuteerButton_Click(System.Object sender, System.EventArgs e)
        {
            string[] woorden = new string[4];
            string[,] permutaties = null;

            woorden[0] = woord1TextBox.Text;
            woorden[1] = woord2TextBox.Text;
            woorden[2] = woord3TextBox.Text;
            woorden[3] = woord4TextBox.Text;

            permutaties = Permuteer(woorden);

            DrukAf(permutaties);
        }

        private string[,] Permuteer(string[] w)
        {

            //triviaal geval
            if (w.Length == 1)
            {
                string[,] permutaties = { { w[0] } };
                return permutaties;
                //semi-triviaal
            }
            else if (w.Length == 2)
            {
                string[,] permutaties = new string[2, 2];
                permutaties[0, 0] = w[0];
                permutaties[0, 1] = w[1];
                permutaties[1, 0] = w[1];
                permutaties[1, 1] = w[0];

                return permutaties;
                //Recursiestap
            }
            else
            {
                //kopieer alle elementen behalve de eerste naar een nieuwe rij
                string[] v = new string[w.Length - 1];
                for (int index = 1; index < w.Length; index++)
                {
                    v[index - 1] = w[index];
                }

                //permuteer deze rij
                string[,] permutaties_v = Permuteer(v);

                //bereken de permutaties van w op basis van die van v
                string[,] permutaties_w = new string[Fac(w.Length), w.Length];

                KopieerEnInserteer(permutaties_v, permutaties_w, w[0]);

                return permutaties_w;
            }
        }

        //kopieer n (= aantal kolommen van p_w) maal de inhoud van p_v naar p_w
        //verondersteld is dat de dimensies van p_v en p_w kloppen
        //inserteer dan op gepaste wijze parameter val
        private void KopieerEnInserteer(string[,] p_v, string[,] p_w, string val)
        {
            int n = p_v.GetLength(1);
            for (int i = 0; i <  p_w.GetLength(1); i++)
            {
                for (int j = 0; j < p_v.GetLength(0); j++)
                {
                    for (int k = 0; k < p_v.GetLength(1); k++)
                    {
                        p_w[n * i + j, k] = p_v[j, k];
                    }
                    Inserteer(val, n * i + j, p_w, i);
                }
            }
        }

        // Inserteer de waarde val in rij op positie pos. De resterende waarden schuiven op naar rechts.
        // Het laatste element wordt dan eventueel overschreven (maar is voor deze toepassing steeds leeg)
        private void Inserteer(string val, int rij, string[,] matrix, int pos)
        {
            for (int i = matrix.GetLength(1) - 2; i >= pos; i -= 1)
            {
                matrix[rij, i + 1] = matrix[rij, i];
            }
            matrix[rij, pos] = val;
        }

        private int Fac(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Fac(n - 1);
            }
        }

        private void DrukAf(string[,] p)
        {
            permutatiesTextBox.Text = string.Empty;
            string lijn = string.Empty;

            for (int i = 0; i < p.GetLength(0); i++)
            {
                lijn = string.Empty;

                for (int j = 0; j < p.GetLength(1); j++)
                {
                    lijn = lijn + " " + p[i, j];
                }
                permutatiesTextBox.AppendText(lijn + "\r\n");
            }
        }
    }
}
