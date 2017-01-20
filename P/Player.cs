using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P
{
    public class Player
    {
        public uint PlayerID { get; set; }
        public uint PlayerStack { get; set; }
        public uint CurrentRaise { get; set; }
        public List<Card> Hand = new List<Card>();
        public Player(int id, uint stack = 1000)
        {
            PlayerID = (uint)id;
            PlayerStack = stack;
        }
        public List<Card> GetCards(List<Card> hand)
        {
            return hand;
        }
        public void MyTurn(int move)
        {
            switch (move)
            {
                case 1:
                    Check();
                    break;
                case 2:
                    Fold();
                    break;
                case 3:
                    Call();
                    break;
                case 4:
                    WriteLine("How much?");
                    uint raiseValue = Convert.ToUInt16(ReadLine());
                    Raise(raiseValue);
                    break;
            }
        }
        public void Check()
        {

        }
        public void Fold()
        {
            Hand.Clear();
        }
        public void Call()
        {

        }
        public uint Raise(uint value)
        {
            PlayerStack -= value;
            CurrentRaise = value;
            return value;
        }
        public void ShowHand()
        {
            foreach (Card c in Hand)
                c.ShowCard();
        }
        public void ShowInfo()
        {
            WriteLine("Player_id: " + PlayerID + "\nStack: " + PlayerStack);
            ShowHand();
        }
    }
}
