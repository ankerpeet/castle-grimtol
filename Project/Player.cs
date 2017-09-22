using System.Collections.Generic;

namespace CastleGrimtol.Project
{
    public class Player : IPlayer
    {
        public int Health { get; set; }
        public int Score { get; set; }
        public List<Item> Inventory { get; set; }

        public Player(int health, int score)
        {
            Health = health;
            Score = score;
            Inventory = new List<Item>();
        }
    }
}