using System;

namespace Command
{
    public class MoveCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Move");
        }
    }
}