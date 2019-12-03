using System;

namespace Command
{
    public class ShootCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Shoot");
        }
    }
}