using System;
using System.Runtime.InteropServices;
using AbstractFactory.MacFactory;
using AbstractFactory.WindowsFactory;

namespace AbstractFactory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            UIFactory uiFactory = null;

            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Console.WriteLine("Sorry, program does not contain UI system for Linus OS for now. Keep trying.");
                return;
            }
            
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                uiFactory = new WindowsUIFactory();

            } else if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                uiFactory = new MacUIFactory();
            }
            
            Console.WriteLine($"UI is built on top of {uiFactory} respectively to OS where you run this program.");
        }
    }
}