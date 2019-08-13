using CodeKata.ScoreKeeperKata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.Tests.ScoreKeeperKata
{
    public class ScoreKeeperTests
    {
        [Test]
        public void ItExists()
        {
            var scoreKeeper = new ScoreKeeper() as IScoreKeeper;
            Assert.IsNotNull(scoreKeeper);
        }

        [Test]
        [TestCase(0, 0, "000:000")]
        [TestCase(1, 1, "001:001")]
        public void GetScore_ReturnsAFormattedString(int startintPointTeamA, int startintPointTeamB, string expectedScore)
        {
            var scoreKeeper = new ScoreKeeper(startintPointTeamA, startintPointTeamB);
            Assert.AreEqual(expectedScore, scoreKeeper.GetScore());
        }

        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        public void ScoreTeamA1_ItScoresOnePointToTeamA(int startintPointTeamA, int expectedPointTeamA)
        {
            var scoreKeeper = new ScoreKeeper(startintPointTeamA, 0);
            Assert.AreEqual(startintPointTeamA, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);

            scoreKeeper.ScoreTeamA1();

            Assert.AreEqual(expectedPointTeamA, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);
        }

        [Test]
        [TestCase(0, 2)]
        [TestCase(1, 3)]
        [TestCase(2, 4)]
        public void ScoreTeamA2_ItScoresTwoPointsToTeamA(int startintPointTeamA, int expectedPointTeamA)
        {
            var scoreKeeper = new ScoreKeeper(startintPointTeamA, 0);
            Assert.AreEqual(startintPointTeamA, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);

            scoreKeeper.ScoreTeamA2();

            Assert.AreEqual(expectedPointTeamA, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);
        }

        [Test]
        [TestCase(0, 3)]
        [TestCase(1, 4)]
        [TestCase(2, 5)]
        public void ScoreTeamA3_ItScoresThreePointsToTeamA(int startintPointTeamA, int expectedPointTeamA)
        {
            var scoreKeeper = new ScoreKeeper(startintPointTeamA, 0);
            Assert.AreEqual(startintPointTeamA, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);

            scoreKeeper.ScoreTeamA3();

            Assert.AreEqual(expectedPointTeamA, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);
        }

        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        public void ScoreTeamB1_ItScoresOnePointToTeamB(int startintPointTeamB, int expectedPointTeamB)
        {
            var scoreKeeper = new ScoreKeeper(0, startintPointTeamB);
            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(startintPointTeamB, scoreKeeper.TeamBScore);

            scoreKeeper.ScoreTeamB1();

            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(expectedPointTeamB, scoreKeeper.TeamBScore);
        }

        [Test]
        [TestCase(0, 2)]
        [TestCase(1, 3)]
        [TestCase(2, 4)]
        public void ScoreTeamB2_ItScoresTwoPointsToTeamB(int startintPointTeamB, int expectedPointTeamB)
        {
            var scoreKeeper = new ScoreKeeper(0, startintPointTeamB);
            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(startintPointTeamB, scoreKeeper.TeamBScore);

            scoreKeeper.ScoreTeamB2();

            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(expectedPointTeamB, scoreKeeper.TeamBScore);
        }

        [Test]
        [TestCase(0,3)]
        [TestCase(1,4)]
        [TestCase(2,5)]
        public void ScoreTeamB3_ItScoresThreePointsToTeamB(int startintPointTeamB, int expectedPointTeamB)
        {
            var scoreKeeper = new ScoreKeeper(0, startintPointTeamB);
            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(startintPointTeamB, scoreKeeper.TeamBScore);

            scoreKeeper.ScoreTeamB3();

            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(expectedPointTeamB, scoreKeeper.TeamBScore);
        }
    }
}
