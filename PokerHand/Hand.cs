using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHand
{
    class Hand
    {
        List<Card> cardList = new List<Card>();

        public Hand(string input)
        {
            var temp = input.Split(',');

            foreach (var item in temp)
            {
                var cardItem = new Card(item);
                cardList.Add(cardItem);

                Console.WriteLine(cardItem.ToString());
            }

        }

        public string GetHandName()
        {

            if (CheckPair(cardList))
            {
                return "Pair";
            }

            else if (CheckTwoPair(cardList))
            {
                return "Two Pair";
            }

            else if (CheckTrips(cardList))
            {
                return "Trips";
            }

            else if (CheckFlush(cardList))
            {
                return "Flush";
            }


            else if (CheckFullHouse(cardList))
            {
                return "Full House";
            }


            else if (CheckQuads(cardList))
            {
                return "Quad";
            }


            return "Error";
        }
        private bool CheckPair(List<Card> cards)
        {
            //see if exactly 2 cards card the same rank.
            return cards.GroupBy(card => card.Value).Count(group => group.Count() == 2) == 1;
        }

        private bool CheckTwoPair(List<Card> cards)
        {
            //see if there are 2 lots of exactly 2 cards card the same rank.
            return cards.GroupBy(card => card.Value).Count(group => group.Count() >= 2) == 2;
        }

        private bool CheckTrips(List<Card> cards)
        {
            //see if exactly 3 cards card the same rank.
            return cards.GroupBy(card => card.Value).Any(group => group.Count() == 3);
        }

        public bool CheckFlush(List<Card> cards)
        {
            //see if 5 or more cards card the same rank.
            return cards.GroupBy(card => card.Suit).Count(group => group.Count() >= 5) == 1;
        }

        public bool CheckFullHouse(List<Card> cards)
        {
            // check if trips and pair is true
            return CheckPair(cards) && CheckTrips(cards);
        }
        public bool CheckQuads(List<Card> cards)
        {
            //see if exactly 4 cards card the same rank.
            return cards.GroupBy(card => card.Value).Any(group => group.Count() == 4);
        }

    }
}
