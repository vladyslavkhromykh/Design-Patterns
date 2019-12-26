using System;
using System.Collections.Generic;

namespace Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Player john = new Player("John", 12);
            Player ken = new Player("Ken", 6);
            Player ben = new Player("Ben", 25);

            List<Player> players = new List<Player>
            {
                john, ken, ben
            };
            
            players.Sort(new Player.HashComparer());
            players.ForEach(player => Console.WriteLine(player.ToString()));
            
            players.Sort(new Player.NameComparer());
            players.ForEach(player => Console.WriteLine(player.ToString()));
        }
    }
}