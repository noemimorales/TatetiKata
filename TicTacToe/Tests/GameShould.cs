using System;
using NUnit.Framework;

namespace TicTacToe
{
    [TestFixture]
    public class GameShould
    {
        Game game;
        [SetUp]
        public void Before()
        {
            game = new Game();
        }
        [Test]
        public void GameOverWhenARowIsComplete()
        {
            //given

            //when
            game.Play(0, 0,"X");
            game.Play(0, 1,"X");
            game.Play(0, 2,"X");

            //then
            Assert.True(game.IsGameOver());
        }

        [TestCase("O","X")]
        [TestCase("X", "O")]
        public void PassTurnAfterPlayO(string currentPlayer, string nextPlayer)
        {
            //given

            //when
            game.Play(0, 0, currentPlayer);
            //then
            Assert.AreEqual(nextPlayer, game.GetCurrentPlayer());
        }
    }
}