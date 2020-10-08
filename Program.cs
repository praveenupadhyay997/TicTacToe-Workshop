using System;

namespace TicTacToeWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe Game");
            TicTacToeClass ticTacToeClass = new TicTacToeClass();
            ticTacToeClass.AssignBoardFirstUseCase();

            char choice;
            Console.WriteLine("Player Enter your choice X or O to the game");
            choice = Convert.ToChar(Console.ReadLine());
            ticTacToeClass.ChoiceInGame(choice);

        }
    }
}
