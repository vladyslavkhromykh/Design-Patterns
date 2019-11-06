namespace Facade
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Serializer serializer = new Serializer(new BinarySerializerInternal());
            var obj = new { Name = "John", Age = 26 };
            serializer.Serialize(obj);
        }
    }
}