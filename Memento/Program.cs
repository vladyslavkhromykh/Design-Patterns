using System;

namespace Memento
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();
            editor.AddLine("First line of code");
            editor.AddLine("Second line of code");
            editor.AddLine("Third line of code");

            Console.WriteLine("Text editor content:");
            Console.WriteLine(editor.GetContent());
            
            TextEditor.Snapshot snapshot = editor.GetSnapshot();
            
            editor.AddLine("Fourth line of code");
            
            Console.WriteLine("Text editor content:");
            Console.WriteLine(editor.GetContent());

            editor.Restore(snapshot);
            
            Console.WriteLine("Text editor content:");
            Console.WriteLine(editor.GetContent());
        }
    }
}