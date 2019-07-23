using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    public class DeckOfCards
    {
        public static int NUMBER_OF_CARDS = 52;
        private Card[] deck = new Card[NUMBER_OF_CARDS];

        private int _currentCard;

        public DeckOfCards(string[] faces, string[] suits)
        {
            _currentCard = -1;

            for (int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card(suits[i / 13], faces[i % 13], i % 13);
            }
        }

        public void Shuffle(int seed)
        {
            Random randomNumber = new Random(seed);
            Card temporaryValue;
            _currentCard = -1;

            for (int i = 0; i < deck.Length; i++)
            {
                int j = randomNumber.Next(52);

                temporaryValue = deck[i];
                deck[i] = deck[j];
                deck[j] = temporaryValue;
            }
        }

        public Card DealCard()
        {
            if (_currentCard + 1 < deck.Length)
            {
                _currentCard += 1;
                return deck[_currentCard];
            }
            else
            {
                return null;
            }
        }

        public int CurrentCard
        {
            get { return _currentCard; }
        }

        public string CurrentFace
        {
            get { return deck[_currentCard].Face; }
        }

        public int CurrentValue
        {
            get { return deck[_currentCard].Value; }
        }
    }
}
