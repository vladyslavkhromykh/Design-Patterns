using System;

namespace Observer
{
    public class TheTimesPublisher : INewspaperPublisher
    {
        public event Action<Newspaper> NewspaperPublished;
        
        private uint currentSerialNumber;
        
        public void Publish()
        {
            currentSerialNumber++;
            var newspaper = new Newspaper(currentSerialNumber, "HURRY TO READ!", "The Times Bla-bla-bla...");
            NewspaperPublished?.Invoke(newspaper);
        }
    }
}