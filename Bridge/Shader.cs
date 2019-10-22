using System;

namespace Bridge
{
    /// <summary>
    /// Shader stands for implementation role in scope of Adapter pattern.
    /// Each shader type is concrete implementation
    /// </summary>
    public abstract class Shader
    {
        public abstract object CalculateOutputTexture();
    }
}