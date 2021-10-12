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
        public char[] getBoard()
        {
            char[] boardCopy = new char[10];
            Array.Copy(board, boardCopy, board.Length);
            return boardCopy;
        }
        private bool IfPositionFree(char[] b, int position)
        {
            if (b[position] == ' ')
            {
                return true;
            }
            else
                return false;
        }

        private void givingPosition(char[] b, int position, char playerInput)
        {
            b[position] = playerInput;
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
              
        public string tossToPlayfirst()
        {
            Random random = new Random();
            int choice = random.Next(0, 2);

            if (choice == 1)
                return "User";
            else
                return "Computer";


        }
        public bool winCondition(char[] b,char input)
        {
            bool topRow = (board[1] == input && board[2] == input && board[3] == input);
            bool middleRow = (board[4] == input && board[5] == input && board[6] == input);
            bool bottomRow = (board[7] == input && board[8] == input && board[9] == input);
            bool leftCol = (board[1] == input && board[4] == input && board[7] == input);
            bool middleCol = (board[2] == input && board[5] == input && board[8] == input);
            bool rightCol = (board[3] == input && board[6] == input && board[9] == input);
            bool firstDiagonal = (board[1] == input && board[5] == input && board[9] == input);
            bool secondDiagonal = (board[3] == input && board[5] == input && board[7] == input);
            return topRow || middleRow || bottomRow || leftCol || rightCol || middleCol || firstDiagonal || secondDiagonal;
        }
        

        public int WinningMove(char input)
        {
            for (int i = 1; i < board.Length; i++)
            {
                char[] boardCopy = getBoard();
                if (IfPositionFree(boardCopy, i))
                {
                    givingPosition(boardCopy, i, input);
                    if (winCondition(boardCopy, input))
                    {
                        return i;
                    }
                        
                }
            }
            return 0;
        }
        public int ComputerMove(char compInput)
        {
            int winningMove = WinningMove(compInput);
            if (winningMove != 0)
                return winningMove;
            return 0;
        }

    }
}
