using System;

namespace dotnetRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("This is player with no name");
            Console.WriteLine("Health: \t{0}", player.Health);
            Console.WriteLine("Mana: \t\t{0}", player.Mana);
            Console.WriteLine("Gold: \t\t{0}", player.Gold);
        }
    }
}
