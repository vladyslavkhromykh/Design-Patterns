namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WorldObjectComponent worldObjectComponent = new WorldObjectComponent();
            GUIComponent guiComponent = new GUIComponent();
            GUIComponentDecorator decorator = new GUIComponentDecorator(guiComponent);
            
            worldObjectComponent.DoAction();
            decorator.DoAction();
        }
    }
}