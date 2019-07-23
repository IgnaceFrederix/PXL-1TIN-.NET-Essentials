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

namespace Oef14_3_Blackjack
{
    public partial class Form1 : Form
    {
        //zeker voldoende
        private int[] speler = new int[21];
        private int[] computer = new int[21];
        private int i;

        //indexen in de beide rijen
        private int j;

        private void Initialize()
        {
            i = -1;
            j = -1;

            kaartLabel.Text = PrintRij(speler, i);
            computerLabel.Text = PrintRij(computer, j);

            nieuwButton.Enabled = false;
        }


        public Form1()
        {
            InitializeComponent();

            Initialize();
        }

        private string PrintRij(int[] rij, int index)
        {
            string s = "";
            for (int i = 0; i <= index; i++)
            {
                s = s + " " + Convert.ToString(rij[i]);
            }
            return s;
        }

        private int Som(int[] rij, int index)
        {
            int s = 0;

            for (int i = 0; i <= index; i++)
            {
                s = s + rij[i];
            }

            return s;
        }

        private int DeelKaart()
        {
            Random r = new Random();
            return r.Next(2, 14);
        }

        private void kaartButton_Click(object sender, EventArgs e)
        {
            i = i + 1;
            speler[i] = DeelKaart();

            kaartLabel.Text = PrintRij(speler, i);

            int s = Som(speler, i);
            if (s > 21)
            {
                MessageBox.Show("U bent verloren, computer tracht nu 21 te halen");
                ComputerAanZet();
            }
            else if (s == 21)
            {
                MessageBox.Show("Proficiat, u heeft 21. U bent gewonnen!");
                nieuwButton.Enabled = true;
            }
        }

        // Strategie computer: in evenveel stappen als de speler een lagere score te halen
        // eventueel stoppen als 21 behaald wordt.
        private void ComputerAanZet()
        {
            int som_c = Som(computer, j);
            int som_s = Som(speler, i);

            while (j < i & som_c < 21)
            {
                j = j + 1;
                computer[j] = DeelKaart();
                som_c = Som(computer, j);
            }

            computerLabel.Text = PrintRij(computer, j);


            if (som_c > 21)
            {
                if (som_s <= 21)
                {
                    MessageBox.Show("Proficiat, u heeft gewonnen");
                }
                else
                {
                    MessageBox.Show("Spel onbeslist");
                }
                // som_c <= 21
            }
            else
            {
                if (som_c > som_s)
                {
                    MessageBox.Show("Computer heeft gewonnen");
                }
                else if (som_s <= 21)
                {
                    MessageBox.Show("Proficiat, u heeft gewonnen");
                }
            }

            nieuwButton.Enabled = true;
        }

        private void  pasButton_Click(object sender, EventArgs e)
        {
            ComputerAanZet();
        }

        private void nieuwButton_Click(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
