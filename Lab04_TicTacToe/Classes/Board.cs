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
        /// The DisplayBoard method loops through a multidimensional array and presents the values of the array as formatted spaces on a game board
        /// </summary>
		public void DisplayBoard()
		{
            int columnLength = GameBoard.GetLength(0);
            int rowLength = (GameBoard.GetLength(1));

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < columnLength; j++)
                {
                    Console.Write($"|{GameBoard[i, j]}|");
                }

                Console.WriteLine();
            }
        }
	}
}
