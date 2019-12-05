using System;
using System.Collections.Generic;

namespace Iterator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {
                5, 103, 44, 255, 900, 42, 167, 433
            };
            
            ListInvertIterator<int> invertIterator = new ListInvertIterator<int>(numbers);

            foreach (var i in invertIterator)
            {
                Console.WriteLine(i);
            }
        }
    }
}