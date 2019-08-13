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
            var scoreKeeper = new ScoreKeeper();
            //scoreKeeper.scoreTeamA1();
            //scoreKeeper.scoreTeamA2();
            //scoreKeeper.scoreTeamA3();
            //scoreKeeper.scoreTeamB1();
            //scoreKeeper.scoreTeamB2();
            //scoreKeeper.scoreTeamB3();
            //var result = scoreKeeper.getScore();
            Assert.IsNotNull(scoreKeeper);
        }

        [Test]
        public void GetScore_ReturnsAFormattedString()
        {
            var scoreKeeper = new ScoreKeeper();
            Assert.AreEqual("000:000", scoreKeeper.GetScore());
        }

        [Test]
        public void ScoreTeamA1_ItScoresOnePointToTeamA()
        {
            var scoreKeeper = new ScoreKeeper();
            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);

            scoreKeeper.ScoreTeamA1();

            Assert.AreEqual(1, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);
        }

        [Test]
        public void ScoreTeamA2_ItScoresTwoPointsToTeamA()
        {
            var scoreKeeper = new ScoreKeeper();
            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);

            scoreKeeper.ScoreTeamA2();

            Assert.AreEqual(2, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);
        }

        [Test]
        public void ScoreTeamA3_ItScoresThreePointsToTeamA()
        {
            var scoreKeeper = new ScoreKeeper();
            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);

            scoreKeeper.ScoreTeamA3();

            Assert.AreEqual(3, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);
        }

        [Test]
        public void ScoreTeamB1_ItScoresOnePointToTeamB()
        {
            var scoreKeeper = new ScoreKeeper();
            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);

            scoreKeeper.ScoreTeamB1();

            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(1, scoreKeeper.TeamBScore);
        }

        [Test]
        public void ScoreTeamB2_ItScoresTwoPointsToTeamB()
        {
            var scoreKeeper = new ScoreKeeper();
            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);

            scoreKeeper.ScoreTeamB2();

            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(2, scoreKeeper.TeamBScore);
        }

        [Test]
        public void ScoreTeamB3_ItScoresThreePointsToTeamB()
        {
            var scoreKeeper = new ScoreKeeper();
            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(0, scoreKeeper.TeamBScore);

            scoreKeeper.ScoreTeamB3();

            Assert.AreEqual(0, scoreKeeper.TeamAScore);
            Assert.AreEqual(3, scoreKeeper.TeamBScore);
        }
    }
}
