using System;

namespace ChainOfResponsibility
{
    public class CanvasElement : IRaycastHandler
    {
        private string name;
        private int rootLevel;
        private CanvasElement parent;
        private bool isInteractable;
        
        public CanvasElement(string name, CanvasElement parent, bool isInteractable)
        {
            this.name = name;
            this.parent = parent;
            if (this.parent != null)
            {
                this.rootLevel = parent.rootLevel++;  
            }
            this.isInteractable = isInteractable;
        }
        

        public IRaycastHandler Next
        {
            get { return parent; }
        }

        public void Handle()
        {
            if (isInteractable)
            {
                Console.WriteLine(string.Format("Register click for {0} element.", this.name));
            }
            else
            {
                Console.WriteLine(string.Format("Can not register click for {0} element.", this.name));
                if (Next == null)
                {
                    Console.WriteLine(string.Format("Raycast handle failed on element: {0}", this.name));
                    return;
                }
                Next.Handle();
            }
        }
    }
}