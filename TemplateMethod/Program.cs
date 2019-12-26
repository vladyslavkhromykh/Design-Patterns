using System;

namespace TemplateMethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Binary logger started...");
            DataLogger binaryLogger = new BinaryLogger();
            binaryLogger.ProcessLog();
            Console.WriteLine();
            
            Console.WriteLine("PDF logger started...");
            DataLogger pdfLogger = new PDFLogger();
            pdfLogger.ProcessLog();
        }
    }
}