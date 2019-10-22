using System;

namespace Bridge
{
    /// <summary>
    /// Material stands for abstraction role in scope of Adapter pattern.
    /// Each material type is refined abstraction.
    /// </summary>
    public abstract class Material
    {
        protected Shader shader;

        public Material(Shader shader)
        {
            this.shader = shader;
        }
        
        public virtual void Draw()
        {
            Console.WriteLine($"Draw {this} with {this.shader} by getting {this.shader.CalculateOutputTexture()}");
        }
    }
}