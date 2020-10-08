using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeWorkshop
{
    class TicTacToeClass
    {
        char[] boardTicTacToe = new char[10];

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
    }
}
