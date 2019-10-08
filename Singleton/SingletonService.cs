namespace Singleton
{
    public class SingletonService
    {
        private static SingletonService instance;

        public static SingletonService Instance => instance ?? (instance = new SingletonService());

        private SingletonService()
        {
            
        }
    }
}