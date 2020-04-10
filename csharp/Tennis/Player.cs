using System;

namespace Tennis
{
    public class Player
    {
        public String Name { get; }
        public int Score { get; set; } = 0;

        public Player(string name)
        {
            this.Name = name;
        }

        public void IncreaseScoreByOne()
        {
            Score++;
        }
    }
}
