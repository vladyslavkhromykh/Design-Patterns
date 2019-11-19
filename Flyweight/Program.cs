using System;
using System.Drawing;

namespace Flyweight
{
    internal class Program
    {
        private static Player[] players;
        private static PlayerSharedData sharedData;
        
        private static void Main(string[] args)
        {
            InitializeSharedData();
            InitializePlayers();
        }

        private static void InitializePlayers()
        {
            int playersCount = 100000;
            players = new Player[playersCount];

            Random random = new Random();
            
            
            for (int i = 0; i < players.Length; i++)
            {
                players[i] = new Player()
                {
                    Id = i,
                    Speed = random.Next(sharedData.MinimalSpeed, sharedData.MaximalSpeed)
                };
            }
        }

        private static void InitializeSharedData()
        {
            sharedData = new PlayerSharedData(1, 5, new Point(0, 0), new Point(500, 500));
        }

        private static void RandomizeSpeedForPlayers()
        {
            Random random = new Random();
            
            for (int i = 0; i < players.Length; i++)
            {
                players[i].Speed = random.Next(sharedData.MinimalSpeed, sharedData.MaximalSpeed);
            }
        }
    }
}