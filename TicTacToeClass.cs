using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeWorkshop
{
    class TicTacToeClass
    {
        /// <summary>
        /// Character array for defining board in the game
        /// </summary>
        char[] boardTicTacToe = new char[10];
        public const char FIRST_CHOICE = 'X';
        public const char SECOND_CHOICE = 'O';
        public char playerOneChoice;
        public char computerChoice;
        /// <summary>
        /// Assigns the board with default null value given.
        /// </summary>
        public char[] AssignBoardFirstUseCase()
        {
            for (int i = 0; i < boardTicTacToe.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                boardTicTacToe[i] = ' ';
            }
            return boardTicTacToe;
        }

        public void ChoiceInGame(char choice)
        {
            if (choice == 'X' || choice == 'x')
            {
                playerOneChoice = FIRST_CHOICE;
                computerChoice = SECOND_CHOICE;
            }
            else
            {
                playerOneChoice = SECOND_CHOICE;
                computerChoice = FIRST_CHOICE;
            }
            Console.WriteLine("Choice of Player is {0} and computer is {1}",playerOneChoice,computerChoice);
        }

        public void ShowBoardInGame(char [] board)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
            Console.WriteLine("     |     |      ");
        }
    }
}
