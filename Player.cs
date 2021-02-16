using System;

namespace dotnetRPG
{
    public class Player
    {
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Experience { get; set; }
        public int Gold { get; set; }   

        public Player()
        {
            this.Health = 100;
            this.Experience = 0;
            this.Mana = 0;
            this.Gold = 0;
        }
    }
}