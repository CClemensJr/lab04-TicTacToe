﻿using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player();

            Game newGame = new Game(p1, p2);

            Player winner = newGame.Play();

            Console.WriteLine($"{ winner.Name } is the winner!");

            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
