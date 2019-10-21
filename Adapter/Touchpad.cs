using System;

namespace Adapter
{
    internal class Touchpad : IPointerDevice
    {
        private ValueTuple<int, int> touchpadPosition; // Tracked by OS.

        public (int, int) PointerScreenPosition()
        {
            return touchpadPosition;
        }
    }
}