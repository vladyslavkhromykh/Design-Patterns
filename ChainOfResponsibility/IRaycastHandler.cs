namespace ChainOfResponsibility
{
    public interface IRaycastHandler
    {
        IRaycastHandler Next { get; }
        void Handle();
    }
}