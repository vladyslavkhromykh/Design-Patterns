namespace AbstractFactory.MacFactory
{
    public sealed class MacUIFactory : UIFactory
    {
        public override UIElement CreateButton()
        {
            return new MacButton();
        }
        
        public override UIElement CreateText()
        {
            return new MacImage();
        }

        public override UIElement CreateImage()
        {
            return new MacImage();
        }
    }
}