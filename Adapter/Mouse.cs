using System;

namespace Adapter
{
    internal class Mouse : IPointerDevice
    {
        private ValueTuple<int, int> mousePosition; // Tracked by OS.

        public (int, int) PointerScreenPosition()
        {
            return mousePosition;
        }
    }
}