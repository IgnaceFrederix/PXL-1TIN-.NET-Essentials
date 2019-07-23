using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    class Card
    {
        public string Suit { get; set; }

        public string Face { get; set; }

        public Card(string suitValue, string faceValue)
        {
            Suit = suitValue;
            Face = faceValue;
        }

        public override string ToString()
        {
            return Face + " of " + Suit;
        }
    }
}
