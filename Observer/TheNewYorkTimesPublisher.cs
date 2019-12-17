using System;

namespace Observer
{
    public class TheNewYorkTimesPublisher : INewspaperPublisher
    {
        public event Action<Newspaper> NewspaperPublished;

        private uint currentSerialNumber;
        
        public void Publish()
        {
            currentSerialNumber++;
            var newspaper = new Newspaper(currentSerialNumber, "HOT NEWS", "The New York Times Bla-bla-bla...");
            NewspaperPublished?.Invoke(newspaper);
        }
    }
}