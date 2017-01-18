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
            WriteLine("POKER TIME!!!");

            Game newGame = new Game(2);
            newGame.InitGame();


            ReadKey();
        }
    }
}
