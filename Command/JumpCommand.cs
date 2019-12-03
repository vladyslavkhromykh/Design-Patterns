using System;

namespace Command
{
    public class JumpCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Jump");
        }
    }
}