namespace AbstractFactory
{
    public abstract class UIFactory
    {
        public abstract UIElement CreateButton();
        public abstract UIElement CreateText();
        public abstract UIElement CreateImage();
    }
}