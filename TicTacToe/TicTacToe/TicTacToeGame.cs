using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class TicTacToeGame
    {
        public char[] board = new char[10];
        public void CreateGameBoard()
        {
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }
        public void showBoard()
        {
            Console.WriteLine(board[0] + " | " + board[1] + " | " + board[2]);
            Console.WriteLine("_________");
            Console.WriteLine(board[3] + " | " + board[4] + " | " + board[5]);
            Console.WriteLine("_________");
            Console.WriteLine(board[6] + " | " + board[7] + " | " + board[8]);
        }
        public void chooseInput()
        {
            char playerInput = ' ';
            Console.Write("Choose your input 'X' or 'O' : ");
            while (playerInput != 'X' && playerInput != 'O')
            {
                playerInput = Convert.ToChar(Console.ReadLine());
                if (playerInput != 'X' && playerInput != 'O')
                {
                   Console.Write("Please enter input 'X' or 'O' : ");
                }
            }
            char compInput;
            if (playerInput == 'X')
                compInput = 'O';
            else
                compInput = 'X';
        }
        public void position()
        {
            int userPositon = 0;
            
            Console.Write("Choose the location on board from position 1 to 9 : ");
            while (userPositon < 1 || userPositon > 10 || board[userPositon] != ' ')
            {
                userPositon = Convert.ToInt32(Console.ReadLine());
                if (userPositon < 1 || userPositon > 10)
                    Console.Write("Please enter a position from 1 to 9: ");
                else if (board[userPositon] != ' ')
                {
                    Console.Write("Position " + userPositon + " is already occupied. Enter some other position : ");
                }

            }
            



        }

    }
}
