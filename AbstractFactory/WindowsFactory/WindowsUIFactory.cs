namespace AbstractFactory.WindowsFactory
{
    public sealed class WindowsUIFactory : UIFactory
    {
        public override UIElement CreateButton()
        {
            return new WindowsButton();
        }
        
        public override UIElement CreateText()
        {
            return new WindowsText();
        }

        public override UIElement CreateImage()
        {
            return new WindowsImage();
        }
    }
}