using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John", 25);
            
            Console.WriteLine("Here is our new person John:");
            Console.WriteLine(john);

            Person johnClone = john.Clone();
            
            Console.WriteLine("Here is our John clone :");
            Console.WriteLine(john);
            
            Console.WriteLine("They both are look the same, are they not?");
        }
    }
}