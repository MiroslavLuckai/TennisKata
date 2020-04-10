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
            if (player1.Score == player2.Score && player1.Score < 3)
            {
                return $"{TennisUtils.IntScoreToString(player1.Score)}-All";
            }
            if (player1.Score == player2.Score && player1.Score > 2)
            {
                return "Deuce";
            }
            if (player1.Score < 4 && player2.Score < 4)
            {
                return $"{TennisUtils.IntScoreToString(player1.Score)}-{TennisUtils.IntScoreToString(player2.Score)}";
            }
            if ((player1.Score - player2.Score) >= 2)
            {
                return "Win for player1";
            }
            if ((player1.Score - player2.Score) <= -2)
            {
                return "Win for player2";
            }
            if (player1.Score > player2.Score)
            {
                return "Advantage player1";
            }
            return "Advantage player2";
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

