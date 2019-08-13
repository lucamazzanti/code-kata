using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.ScoreKeeperKata
{
    public class ScoreKeeper : IScoreKeeper
    {
        public ScoreKeeper(int teamAScore = 0, int teamBScore = 0)
        {
            TeamAScore = teamAScore;
            TeamBScore = teamBScore;
        }

        public int TeamAScore { get; private set; }
        public int TeamBScore { get; private set; }

        public string GetScore()
        {
            return $"{TeamAScore:000}:{TeamAScore:000}";
        }

        public void ScoreTeamA1()
        {
            TeamAScore += 1;
        }

        public void ScoreTeamA2()
        {
            TeamAScore += 2;
        }

        public void ScoreTeamA3()
        {
            TeamAScore += 3;
        }

        public void ScoreTeamB1()
        {
            TeamBScore += 1;
        }

        public void ScoreTeamB2()
        {
            TeamBScore += 2;
        }

        public void ScoreTeamB3()
        {
            TeamBScore += 3;
        }
    }
}
