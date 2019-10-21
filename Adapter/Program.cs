
namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Mouse mouse = new Mouse();
            mouse.PointerScreenPosition();
            
            Touchpad touchpad = new Touchpad();
            touchpad.PointerScreenPosition();
            
            WebCamera webCamera = new WebCamera();
            WebCameraToIPointerDeviceAdapter cameraAdapter = new WebCameraToIPointerDeviceAdapter(webCamera);
            cameraAdapter.PointerScreenPosition();
        }
    }
}