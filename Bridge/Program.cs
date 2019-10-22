
namespace Bridge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var characterMaterial = new CharacterMaterial(new TextureShader("character texture"));
            var environmentMaterial = new EnvironmentMaterial(new TextureShader("enc texture"));
            var propsMaterial = new PropsMaterial(new ColorShader("white color"));
            
            characterMaterial.Draw();
            environmentMaterial.Draw();
            propsMaterial.Draw();
        }
    }
}