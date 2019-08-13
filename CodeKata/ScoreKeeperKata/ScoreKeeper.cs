using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata.ScoreKeeperKata
{
    public class ScoreKeeper
    { 
        public int TeamAScore { get; private set; }
        public int TeamBScore { get; private set; }

        public string GetScore()
        {
            return "000:000";
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
