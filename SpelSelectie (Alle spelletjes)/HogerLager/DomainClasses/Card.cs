using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    public class Card
    {
        public string Suit { get; set; }

        public string Face { get; set; }

        public int Value { get; set; }

        public Card(string suitValue, string faceValue, int value)
        {
            Suit = suitValue;
            Face = faceValue;
            Value = value;
        }

        public override string ToString()
        {
            return Face + " of " + Suit;
        }
    }
}
