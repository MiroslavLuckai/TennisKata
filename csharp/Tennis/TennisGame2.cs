namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private readonly Player player1;
        private readonly Player player2;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1 = new Player(player1Name);
            this.player2 = new Player(player2Name);
        }

        public string GetScore()
        {
            if (IsPlayersScoreEqual() && IsPlayersScoreLowerThen(3))
            {
                return $"{TennisUtils.IntScoreToString(player1.Score)}-All";
            }
            if (IsPlayersScoreEqual() && IsPlayersScoreHigherThen(2))
            {
                return "Deuce";
            }
            if (IsPlayersScoreLowerThen(4))
            {
                return $"{TennisUtils.IntScoreToString(player1.Score)}-{TennisUtils.IntScoreToString(player2.Score)}";
            }
            if (GetScoreDifference() >= 2)
            {
                return "Win for player1";
            }
            if (GetScoreDifference() <= -2)
            {
                return "Win for player2";
            }
            if (GetScoreDifference() == 1)
            {
                return "Advantage player1";
            }
            return "Advantage player2";
        }

        private bool IsPlayersScoreEqual()
        {
            return player1.Score == player2.Score;
        }

        private bool IsPlayersScoreLowerThen(int limit)
        {
            return player1.Score < limit && player2.Score < limit;
        }

        private bool IsPlayersScoreHigherThen(int limit)
        {
            return player1.Score > limit && player2.Score > limit;
        }

        private int GetScoreDifference()
        {
            return player1.Score - player2.Score;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1.Name)
                player1.IncreaseScoreByOne();
            else
                player2.IncreaseScoreByOne();
        }

    }
}

