using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P
{

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\t\t\tPOKER TIME!!!");

            Game newGame = new Game(3);
            newGame.CreatePlayers();


            newGame.InitGame();
            newGame.GameTurn();
            //newGame.GameInfo();
            //newGame.GameTurn();



            ReadKey();
        }
    }
}
