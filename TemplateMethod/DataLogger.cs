using System;

namespace TemplateMethod
{
    public abstract class DataLogger
    {
        public void ProcessLog()
        {
            object rawData = GetRawDataSample();
            object compressed = CompressData(rawData);
            object convertedData = ConvertData(compressed);
            SaveData(convertedData);
        }

        protected object GetRawDataSample()
        {
            Console.WriteLine("Get raw data sample.");
            return null;
        }

        protected object CompressData(object data)
        {
            Console.WriteLine("Compress data.");
            return null;
        }

        protected abstract object ConvertData(object data);

        protected abstract void SaveData(object data);
    }
}