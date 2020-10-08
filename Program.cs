using System;

namespace TicTacToeWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] board = new char[10];
            char playerChoice, computerChoice;
            Console.WriteLine("Welcome to Tic-Tac-Toe Game");
            TicTacToeClass ticTacToeClass = new TicTacToeClass();
            board = ticTacToeClass.AssignBoardFirstUseCase();

            Console.WriteLine("Player Enter your choice X or O to the game");
            playerChoice = Convert.ToChar(Console.ReadLine().ToUpper());
            computerChoice = (playerChoice == 'X' ? 'O' : 'X');
            if (playerChoice == 'X' || playerChoice == 'O')
            {
                ticTacToeClass.ChoiceInGame(playerChoice);
            }
            else
                Console.WriteLine("Wrong charactered entered User");

            ticTacToeClass.ShowBoardInGame(board);

        }
    }
}
