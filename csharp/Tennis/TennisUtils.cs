namespace Tennis
{
    public static class TennisUtils
    {
        public static string IntScoreToString(int score)
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
