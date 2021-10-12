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
            string firstAttempt = ticTacToe.tossToPlayfirst();
            Console.WriteLine(firstAttempt + " will play first");
            ticTacToe.position();
            if (firstAttempt == "Computer")
            {
                Console.WriteLine("Computer Move : " + ticTacToe.ComputerMove());
            }
            else
            {
                ticTacToe.position();
            }

        }
        public static TicTacToeGame ticTacToe = new TicTacToeGame();
    }
}
        
     

    

