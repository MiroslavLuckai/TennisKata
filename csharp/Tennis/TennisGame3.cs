namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int player2Points;
        private int player1Points;
        private string player1Name;
        private string player2Name;
        private readonly string[] options = { "Love", "Fifteen", "Thirty", "Forty" };

        public TennisGame3(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string GetScore()
        {
            string score;
            if ((player1Points < 4 && player2Points < 4) && (player1Points + player2Points < 6))
            {
                score = options[player1Points];
                return (player1Points == player2Points) ? score + "-All" : score + "-" + options[player2Points];
            }
            if (player1Points == player2Points)
                return "Deuce";
            score = player1Points > player2Points ? player1Name : player2Name;
            return ((player1Points - player2Points) * (player1Points - player2Points) == 1) ? "Advantage " + score : "Win for " + score;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1Name)
                this.player1Points++;
            else
                this.player2Points++;
        }

    }
}

