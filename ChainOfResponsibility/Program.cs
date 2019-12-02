
namespace ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CanvasElement canvas = new CanvasElement("canvas", null, true);
            CanvasElement gameGUI = new CanvasElement("game-gui", canvas, true);
            var topGamePanel = new CanvasElement("top-game-panel", gameGUI, true);
            var menuButton = new CanvasElement("menu-button", topGamePanel, false);
            var menuButtonText = new CanvasElement("menu-button-text",menuButton, false);
            
            InputRaycast.Raycast(menuButtonText);
        }
    }
}