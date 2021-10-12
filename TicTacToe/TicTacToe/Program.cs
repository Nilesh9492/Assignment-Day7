using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game !");
            ticTacToe.CreateGameBoard();

        }
        public static TicTacToeGame ticTacToe = new TicTacToeGame();
    }
}
        
     

    

