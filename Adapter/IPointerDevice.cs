using System;

namespace Adapter
{
    internal interface IPointerDevice
    {
        ValueTuple<int, int> PointerScreenPosition();
    }
}