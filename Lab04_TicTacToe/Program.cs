using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Console.WriteLine("Players created World!");


            Game newGame = new Game(p1, p2);


        }
    }
}
