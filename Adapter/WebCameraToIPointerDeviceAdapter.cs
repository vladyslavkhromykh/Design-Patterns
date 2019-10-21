namespace Adapter
{
    internal class WebCameraToIPointerDeviceAdapter : IPointerDevice
    {
        private WebCamera webCamera;
        private IPointerDevice _pointerDeviceImplementation;

        internal WebCameraToIPointerDeviceAdapter(WebCamera webCamera)
        {
            this.webCamera = webCamera;
        }

        private (int, int) GetUserViewPointOnScreen()
        {
            int averageLookDirectionX =
                (webCamera.LeftEyLookDirection().Item1 + webCamera.RightEyeLookDirection().Item1) / 2;
            int averageLookDirectionY =
                (webCamera.LeftEyLookDirection().Item2 + webCamera.RightEyeLookDirection().Item2) / 2;
            return (averageLookDirectionX, averageLookDirectionY);
        }
        
        public (int, int) PointerScreenPosition()
        {
            return GetUserViewPointOnScreen();
        }
    }
}