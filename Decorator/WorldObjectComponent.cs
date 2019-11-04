using System;

namespace Decorator
{
    public class WorldObjectComponent : Component
    {
        public override void DoAction()
        {
            Console.WriteLine("Do some action in game world.");
        }
    }
}