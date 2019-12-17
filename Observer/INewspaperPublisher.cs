using System;

namespace Observer
{
    public interface INewspaperPublisher
    {
        event Action<Newspaper> NewspaperPublished;
        void Publish();
    }
}