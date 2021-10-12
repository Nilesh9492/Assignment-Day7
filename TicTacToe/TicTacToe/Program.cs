using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game !");
            ticTacToe.CreateGameBoard();
            ticTacToe.chooseInput();
            ticTacToe.showBoard();
            ticTacToe.position();

        }
        public static TicTacToeGame ticTacToe = new TicTacToeGame();
    }
}
        
     

    

