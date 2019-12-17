namespace Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            INewspaperPublisher newYorkTimes = new TheNewYorkTimesPublisher();
            INewspaperPublisher times = new TheTimesPublisher();
            
            IReader john = new Person();
            IReader david = new Person();

            newYorkTimes.NewspaperPublished += john.OnNewspaperPublished;
            times.NewspaperPublished += john.OnNewspaperPublished;
            times.NewspaperPublished += david.OnNewspaperPublished;
            
            newYorkTimes.Publish();
            times.Publish();
        }
    }
}