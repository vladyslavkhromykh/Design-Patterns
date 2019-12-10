namespace Mediator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ChatRoom chat = new ChatRoom();
            User vlad = new User("Vlad", chat);
            User stas = new User("Stas", chat);
            
            vlad.SendMessage("Hi! Who is there?");
            stas.SendMessage("Hi, Vlad. It is me!");
            vlad.SendMessage("Great! Bye :)");
        }
    }
}