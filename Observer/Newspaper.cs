namespace Observer
{
    public class Newspaper
    {
        public uint SerialNumber { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }

        public Newspaper(uint serialNumber, string title, string content)
        {
            this.SerialNumber = serialNumber;
            this.Title = title;
            this.Content = content;
        }
    }
}