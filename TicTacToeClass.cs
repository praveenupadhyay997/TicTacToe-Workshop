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
        public static char[] boardTicTacToe = new char[10];
        public const char FIRST_CHOICE = 'X';
        public const char SECOND_CHOICE = 'O';
        public static char playerOneChoice;
        public static char computerChoice;
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
        /// <summary>
        /// Choices the in game.
        /// </summary>
        /// <param name="choice">The choice.</param>
        public static void ChoiceInGame(char choice)
        {
            if (choice == 'X')
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
        /// <summary>
        /// Shows the board in game.
        /// </summary>
        /// <param name="board">The board.</param>
        public static void ShowBoardInGame(char [] board)
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

        public static void AllowUserForMove(char [] board, int chanceOfPlayer)
        {
            for(int i=1; i<boardTicTacToe.Length; i++)
            {
                boardTicTacToe[i] = board[i];
            }
            if(chanceOfPlayer==1)
            {
                Console.WriteLine("Player - Enter any position to place your move ");
                int position = Convert.ToInt32(Console.ReadLine());
                if (boardTicTacToe[position] == ' ')
                {
                    boardTicTacToe[position] = playerOneChoice;
                }
                else
                {
                    Console.WriteLine("The Position is already occupied. Select Other position");
                }
            }
            else
            {
                Console.WriteLine("Computer - Enter any position to place your move ");
                int position = Convert.ToInt32(Console.ReadLine());
                if (boardTicTacToe[position] == ' ')
                {
                    boardTicTacToe[position] = computerChoice;
                }
                else
                {
                    Console.WriteLine("The Position is already occupied. Select Other position");
                }
            }
            ShowBoardInGame(board);
        }
    }
}
