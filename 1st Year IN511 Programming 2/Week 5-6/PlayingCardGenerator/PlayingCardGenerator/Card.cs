using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardGenerator
{
    public class Card
    {
        private eSuit Suit;
        private eRank Rank;

        public Card(eRank Rank, eSuit Suit)
        {
            this.Rank = Rank;
            this.Suit = Suit;
        }

        public override String ToString()
        {
            return Rank.ToString() + " of " + Suit.ToString();
        }

    }
}
