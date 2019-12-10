using System;

namespace Mediator
{
    public class ChatRoom
    {
        public void SendMessage(User user, string message)
        {
            string formattedMessage = string.Format("{0} sent a message {1}. Date: {2}", user.Name, message,
                System.DateTime.Now);
            Console.WriteLine(formattedMessage);
        }
    }
}