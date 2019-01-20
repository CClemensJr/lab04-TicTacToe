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
            Board testBoard = new Board();

            testGame.Board.GameBoard[0, 0] = test1.Marker;
            testGame.Board.GameBoard[0, 1] = test1.Marker;
            testGame.Board.GameBoard[0, 2] = test1.Marker;

            Assert.True(testGame.CheckForWinner(testBoard));
        }

        [Fact]
        public void ShouldSwitchPlayers()
        {
            Player test1 = new Player();
            Player test2 = new Player();

            Game testGame = new Game(test1, test2);

            testGame.SwitchPlayer();

            Assert.True(test2.IsTurn);
        }

        [Fact]
        public void ArrayShouldMatchPlayerInput()
        {
            Player test1 = new Player();
            Player test2 = new Player();

            Game testGame = new Game(test1, test2);
            
            Position testPosition = Player.PositionForNumber(1);

            Assert.Equal(0, testPosition.Column);
            Assert.Equal(0, testPosition.Row);
        }

        [Fact]
        public void Player1ShouldHaveX()
        {
            Player test1 = new Player();
            Player test2 = new Player();

            Game testGame = new Game(test1, test2);

            Assert.Equal("X", test1.Marker);
        }
    }
}
