namespace Facade
{
    public class Serializer
    {
        private SerializerInternal serializerInternal;
        
        public Serializer(SerializerInternal serializerInternal)
        {
            this.serializerInternal = serializerInternal;
        }
        public void Serialize(object obj)
        {
            object graph = serializerInternal.ConstructObjectGraph(obj);
            byte[] data = serializerInternal.ConvertObjectGraphToByteArray(graph);
            serializerInternal.SaveByteArrayToStream(data);
        }
    }
}