using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P
{
    class Game
    {
        public int NumOfPlayers { get; set; }
        public uint GameStack { get; set; }
        public uint CurrentRound { get; set; }
        public List<Player> Players = new List<Player>();
        public List<Card> CardsOnTable = new List<Card>();
        public Deck DeckA = new Deck();
        public Game(int nop)
        {
            NumOfPlayers = nop;
            CurrentRound = 0;
        }
        public void CreatePlayers()
        {
            for (int i = 0; i < NumOfPlayers; i++)
            {
                Players.Add(new Player(i));
            }
        }
        public void InitGame()
        {
            DealCards();
            List<Card> flop = Flop(ref DeckA);
            List<Card> turn = Turn(ref DeckA);
            List<Card> river = River(ref DeckA);

            CardsOnTable.AddRange(flop);
            CardsOnTable.AddRange(turn);
            CardsOnTable.AddRange(river);

        }
        public void DealCards()
        {
            // Deal cards to players
            //Give Cards to players
            for (int i = 0; i < NumOfPlayers; i++)
            {
                Players[i].Hand = DeckA.DealCards();
            }

        }
        public void ResetDeck()
        {
            // ResetDECK
            DeckA.DeckCards.Clear();
            CardsOnTable.Clear();
            DeckA.DeckCards = DeckA.PopulateDeck();
            CurrentRound += 1;


        }
        private List<Card> Flop(ref Deck deckrest)
        {
            //Select 3 cards from deck and add to table
            List<Card> flop = deckrest.DealCards(3);
            return flop;
        }
        public List<Card> River(ref Deck deckrest)
        {
            //Selec 1 card from deck and add to table
            List<Card> river = deckrest.DealCards(1);
            return river;
        }
        public List<Card> Turn(ref Deck deckrest)
        {
            // Select 1 card from deck and add to table
            List<Card> turn = deckrest.DealCards(1);
            return turn;
        }
        public void Showdown()
        {

        }
        public void CheckWhoseTurnItIs()
        {

        }
        public void GameInfo()
        {
            WriteLine("Current round: " + CurrentRound + "\nNumber of Players: " + NumOfPlayers);
            foreach (Card i in CardsOnTable)
                i.ShowCard();
        }


    }
}
