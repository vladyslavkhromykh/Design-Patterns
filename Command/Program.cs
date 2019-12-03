namespace Command
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ICommand moveCommand = new MoveCommand();
            ICommand jumpCommand = new JumpCommand();
            ICommand shootCommand = new ShootCommand();
            
            InputHandler inputHandler = new InputHandler(moveCommand, jumpCommand, shootCommand);
        }
    }
}