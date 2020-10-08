using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace TicTacToeWorkshop
{
    class Program
    {
        public static char[] board = new char[10];
        public static char playerChoice, computerChoice;
        public static TicTacToeClass ticTacToeClass = new TicTacToeClass();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe Game");

            board = ticTacToeClass.AssignBoardFirstUseCase();

            Console.WriteLine("Player Enter your choice X or O to the game");
            playerChoice = Convert.ToChar(Console.ReadLine().ToUpper());
            computerChoice = (playerChoice == 'X' ? 'O' : 'X');
            if (playerChoice == 'X' || playerChoice == 'O')
            {
                TicTacToeClass.ChoiceInGame(playerChoice);
            }
            else
                Console.WriteLine("Wrong charactered entered User");


            TicTacToeClass.ShowBoardInGame(board);

            int chance = 1;
            TicTacToeClass.AllowUserForMove(board, chance);
        }
    }
}
