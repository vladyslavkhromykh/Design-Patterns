
namespace Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITextValidator defaultTextValidator = new TextValidator();
            
            // Use childTextValidator for cases where program should care about adult text content.
            ITextValidator childTextValidator = new ChildTextValidator(defaultTextValidator);
            
        }
    }
}