using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P
{
    class Player
    {
        public int PlayerID { get; set; }
        public List<Card> Hand = new List<Card>();
        public Player(int id)
        {
            PlayerID = id;
        }
        public List<Card> GetCards(List<Card> hand)
        {
            return hand;
        }
        public void Check()
        {

        }
        public void Fold()
        {

        }
        public void Call()
        {

        }
        public void Raise()
        {

        }
        public void ShowHand()
        {
            foreach (Card c in Hand)
                c.ShowCard();
        }
    }
}
