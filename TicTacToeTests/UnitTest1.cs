using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturnWinner()
        {
            Player test1 = new Player();
            Player test2 = new Player();

            Game testGame = new Game(test1, test2);
            Board board = new Board();


            Assert.True(testGame.CheckForWinner(board));
        }

        [Fact]
        public void ShouldSwitchPlayers()
        {

        }

        [Fact]
        public void ShouldMatch()
        {

        }

        [Fact]
        public void ShouldReturnPlayer()
        {

        }
    }
}
