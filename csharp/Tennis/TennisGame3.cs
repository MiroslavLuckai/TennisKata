using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private readonly Player player1;
        private readonly Player player2;
        private readonly string[] options = { "Love", "Fifteen", "Thirty", "Forty" };

        public TennisGame3(string player1Name, string player2Name)
        {
            this.player1 = new Player(player1Name);
            this.player2 = new Player(player2Name);
        }

        public string GetScore()
        {
            if (PlayersPointsLessThanFour() && (player1.Score + player2.Score < 6))
            {
                string score = options[player1.Score];
                return PlayersPointsEqual() ? score + "-All" : score + "-" + options[player2.Score];
            }
            if (PlayersPointsEqual())
                return "Deuce";
            string betterPlayer = player1.Score > player2.Score ? player1.Name : player2.Name;
            return (AbsoluteValueOfPlayersScoreDifference() == 1) ? "Advantage " + betterPlayer : "Win for " + betterPlayer;
        }

        private bool PlayersPointsEqual()
        {
            return player1.Score == player2.Score;
        }

        private bool PlayersPointsLessThanFour()
        {
            return player1.Score < 4 && player2.Score < 4;
        }

        private int AbsoluteValueOfPlayersScoreDifference()
        {
            return Math.Abs(player1.Score - player2.Score);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1.Name)
                player1.IncreaseScoreByOne();
            else
                player2.IncreaseScoreByOne();       }

    }
}

