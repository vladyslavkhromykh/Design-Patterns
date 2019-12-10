namespace Mediator
{
    public class User
    {
        public string Name { get; private set; }
        private ChatRoom chatRoom;
        
        public User(string name, ChatRoom room)
        {
            this.Name = name;
            this.chatRoom = room;
        }

        public void SendMessage(string message)
        {
            this.chatRoom.SendMessage(this, message);
        }
    }
}