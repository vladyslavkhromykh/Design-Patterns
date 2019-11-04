using System;

namespace Decorator
{
    public class GUIComponent : Component
    {
        public override void DoAction()
        {
            Console.WriteLine("Do some action in GUI.");
        }
    }
}