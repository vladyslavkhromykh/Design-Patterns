using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singletonService = SingletonService.Instance;
            // Do whatever you want with single entry point with no ability to change it.
        }
    }
}