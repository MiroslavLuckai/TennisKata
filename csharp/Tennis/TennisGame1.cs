namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private readonly Player player1;
        private readonly Player player2;

        public TennisGame1(string player1Name, string player2Name)
        {
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1.Name)
                player1.IncreaseScoreByOne();
            else
                player2.IncreaseScoreByOne();
        }

        public string GetScore()
        {
            if (player1.Score == player2.Score)
            {
                if (player1.Score < 3)
                {
                    return $"{IntScoreToString(player1.Score)}-All";
                }
                return "Deuce";
            }
            else if (player1.Score >= 4 || player2.Score >= 4)
            {
                var minusResult = player1.Score - player2.Score;
                if (minusResult == 1) return "Advantage player1";
                else if (minusResult == -1) return "Advantage player2";
                else if (minusResult >= 2) return "Win for player1";
                else return "Win for player2";
            }
            else
            {
                return $"{IntScoreToString(player1.Score)}-{IntScoreToString(player2.Score)}";
            }
        }

        private string IntScoreToString(int score)
        {
            switch (score)
            {
                case 0:
                    return "Love";
                case 1:
                    return "Fifteen";
                case 2:
                    return "Thirty";
                case 3:
                    return "Forty";
                default:
                    return string.Empty;
            }
        }
    }
}

