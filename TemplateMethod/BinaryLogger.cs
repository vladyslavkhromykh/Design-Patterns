using System;

namespace TemplateMethod
{
    public class BinaryLogger : DataLogger
    {
        protected override object ConvertData(object data)
        {
            Console.WriteLine("Convert data to binary format.");
            return null;
        }

        protected override void SaveData(object data)
        {
            Console.WriteLine("Save pdf file on server.");
        }
    }
}