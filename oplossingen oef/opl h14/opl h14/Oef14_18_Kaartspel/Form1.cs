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

namespace Oef14_18_Kaartspel
{
    public partial class Form1 : Form
    {
        private Card[] deck = new Card[52];
        private string[] suits = { "Clubs", "Diamonds", "Spades", "Hearts" };

        public Form1()
        {
            InitializeComponent();
        }

       
        private void stokButton_Click(System.Object sender, System.EventArgs e)
        {
            int index = 0;

            foreach (string suit in suits)
            {
                for (int j = 2; j <= 14; j++)
                {
                    deck[index] = new Card();
                    deck[index].Rank = j;
                    deck[index].Suit = suit;
                    stokTextBox.AppendText(deck[index].ToString() + "\r\n");
                    index = index + 1;
                }
            }
        }
    }
}
