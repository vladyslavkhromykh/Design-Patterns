using System.Drawing;

namespace Bridge
{
    public class ColorShader : Shader
    {
        private string color;
        
        public ColorShader(string color)
        {
            this.color = color;
        } 
        
        public override object CalculateOutputTexture()
        {
            return color;
        }
    }
}