namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int p1point;
        private int p2point;
        private string player1Name;
        private string player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            p1point = 0;
            this.player2Name = player2Name;
        }

        public string GetScore()
        {
            if (p1point == p2point && p1point < 3)
            {
                return $"{TennisUtils.IntScoreToString(p1point)}-All";
            }
            if (p1point == p2point && p1point > 2)
            {
                return "Deuce";
            }
            if (p1point < 4 && p2point < 4)
            {
                return $"{TennisUtils.IntScoreToString(p1point)}-{TennisUtils.IntScoreToString(p2point)}";
            }
            if ((p1point - p2point) >= 2)
            {
                return "Win for player1";
            }
            if ((p2point - p1point) >= 2)
            {
                return "Win for player2";
            }
            if (p1point > p2point)
            {
                return "Advantage player1";
            }
            return "Advantage player2";
        }

        private void P1Score()
        {
            p1point++;
        }

        private void P2Score()
        {
            p2point++;
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                P1Score();
            else
                P2Score();
        }

    }
}

