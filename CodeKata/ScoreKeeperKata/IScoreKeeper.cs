namespace CodeKata.ScoreKeeperKata
{
    public interface IScoreKeeper
    {
        string GetScore();
        void ScoreTeamA1();
        void ScoreTeamA2();
        void ScoreTeamA3();
        void ScoreTeamB1();
        void ScoreTeamB2();
        void ScoreTeamB3();
    }
}