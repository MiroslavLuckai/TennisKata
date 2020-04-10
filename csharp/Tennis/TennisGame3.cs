using System;

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
            if (PlayersPointsLessThanFour() && (player1Points + player2Points < 6))
            {
                string score = options[player1Points];
                return PlayersPointsEqual() ? score + "-All" : score + "-" + options[player2Points];
            }
            if (PlayersPointsEqual())
                return "Deuce";
            string betterPlayer = player1Points > player2Points ? player1Name : player2Name;
            return (AbsoluteValueOfPlayersScoreDifference() == 1) ? "Advantage " + betterPlayer : "Win for " + betterPlayer;
        }

        private bool PlayersPointsEqual()
        {
            return player1Points == player2Points;
        }

        private bool PlayersPointsLessThanFour()
        {
            return player1Points < 4 && player2Points < 4;
        }

        private int AbsoluteValueOfPlayersScoreDifference()
        {
            return Math.Abs(player1Points - player2Points);
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

