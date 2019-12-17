using System;

namespace Observer
{
    public class Person : IReader
    {
        public void OnNewspaperPublished(Newspaper newspaper)
        {
            Console.WriteLine("Reading " + newspaper.Content);
        }
    }
}