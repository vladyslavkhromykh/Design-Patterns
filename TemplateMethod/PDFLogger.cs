﻿using System;

namespace TemplateMethod
{
    public class PDFLogger : DataLogger
    {
        protected override object ConvertData(object data)
        {
            Console.WriteLine("Convert data to pdf format.");
            return null;
        }

        protected override void SaveData(object data)
        {
            Console.WriteLine("Save pdf file on disk.");
        }
    }
}