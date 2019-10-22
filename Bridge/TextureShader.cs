namespace Bridge
{
    public class TextureShader : Shader
    {
        private string texture;
        
        public TextureShader(string texture)
        {
            this.texture = texture;
        } 
        
        public override object CalculateOutputTexture()
        {
            return texture;
        }
    }
}