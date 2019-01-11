using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
        /// The DisplayBoard method loops through a multidimensional array
        /// </summary>
		public void DisplayBoard()
		{
            int totalLength = GameBoard.GetLength(0);
            int rowLength = (GameBoard.GetLength(1));

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < rowLength; j++)
                {
                    Console.Write($"|{GameBoard[i, j]}|");
                }

                Console.WriteLine();
            }
        }
	}
}
