namespace Facade
{
    public abstract class SerializerInternal
    {
        internal abstract object ConstructObjectGraph(object obj);
        internal abstract byte[] ConvertObjectGraphToByteArray(object graph);
        internal abstract void SaveByteArrayToStream(byte[] array);
    }
}