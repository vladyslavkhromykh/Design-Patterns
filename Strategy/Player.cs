using System;
using System.Collections.Generic;

namespace Strategy
{
    public class Player
    {
        private string name;
        private int hash;
        
        public Player(string name, int hash)
        {
            this.name = name;
            this.hash = hash;
        }

        public override string ToString()
        {
            return string.Format($"Name: {name}. Hash: {hash}.");
        }

        public class NameComparer : IComparer<Player>
        {
            public int Compare(Player x, Player y)
            {
                return String.CompareOrdinal(x.name, y.name);
            }
        }
        
        public class HashComparer : IComparer<Player>
        {
            public int Compare(Player x, Player y)
            {
                if (x.hash > y.hash)
                {
                    return 1;
                }

                if (x.hash < y.hash)
                {
                    return -1;
                }

                return 0;
            }
        }
    }
}