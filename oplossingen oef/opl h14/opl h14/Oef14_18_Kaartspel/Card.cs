//-----------------------------------------------------------------------------
// Programmeren in C#: oplossingen oefeningen
// Auteur: Kris.Hermans@live.be
// Copyright (c) 2011 Pearson Education Benelux
//-----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oef14_18_Kaartspel
{
    public class Card
    {
        private int rank;
        private string suit;

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public string Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public override string ToString()
        {
            string tmp = null;

            switch (rank)
            {
                case 2:
                    tmp = "Two";
                    break;
                case 3:
                    tmp = "Three";
                    break;
                case 4:
                    tmp = "Four";
                    break;
                case 5:
                    tmp = "Five";
                    break;
                case 6:
                    tmp = "Six";
                    break;
                case 7:
                    tmp = "Seven";
                    break;
                case 8:
                    tmp = "Eight";
                    break;
                case 9:
                    tmp = "Nine";
                    break;
                case 10:
                    tmp = "Ten";
                    break;
                case 11:
                    tmp = "Jack";
                    break;
                case 12:
                    tmp = "Queen";
                    break;
                case 13:
                    tmp = "King";
                    break;
                case 14:
                    tmp = "Ace";
                    break;
                default:
                    tmp = Convert.ToString(Rank);
                    break;
            }
            return tmp + " Of " + suit;
        }
    }
}
