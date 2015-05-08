using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCardGenerator
{
    public class Deck
    {
        private const int NCARDS = 52;

        private Card[] cards;
        private Random random;

        public Card[] Cards
        {
            get { return cards; }
            set { cards = value; }
        }

        public Deck(Random random)
        {
            cards = new Card[NCARDS];
            int suitLength = cards.Length / 4;
            for (int i = 0; i < suitLength; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cards[(i * 4) + j] = new Card(((eRank)i + 1), (eSuit)j);
                }
            }
            this.random = random;
        }
        
        
        public String SelectACard()
        {
            int index = random.Next(NCARDS);
            return cards[index].ToString();
        }
    }
}
