using System;

namespace Decorator
{
    public class GUIComponentDecorator : Component
    {
        private GUIComponent component;
        
        public GUIComponentDecorator(GUIComponent component)
        {
            this.component = component;
        }
        
        public override void DoAction()
        {
            Console.WriteLine("Decorate GUI action.");
            component.DoAction();
        }
    }
}