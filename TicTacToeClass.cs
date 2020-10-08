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
        public void AssignBoardFirstUseCase()
        {
            for (int i = 0; i < boardTicTacToe.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                boardTicTacToe[i] = ' ';
            }
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
            Console.WriteLine("Choice of Player is={0} and computer is {1}",playerOneChoice,computerChoice);
        }
    }
}
