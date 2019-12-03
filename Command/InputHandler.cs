using System;

namespace Command
{
    public class InputHandler
    {
        public InputHandler(ICommand moveCommand, ICommand jumpCommand, ICommand shootCommand)
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.W)
                {
                    moveCommand.Execute();
                }
                
                if (key.Key == ConsoleKey.Spacebar)
                {
                    jumpCommand.Execute();
                }

                if (key.Key == ConsoleKey.Enter)
                {
                    shootCommand.Execute();
                }
            }
        }
    }
}