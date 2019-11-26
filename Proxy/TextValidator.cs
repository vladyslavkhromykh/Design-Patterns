
namespace Proxy
{
    /// <summary>
    /// Default text validator.
    /// </summary>
    public class TextValidator : ITextValidator
    {
        /// <summary>
        /// This method would return localized string for some predefined key.
        /// </summary>
        /// <param name="key">Key.</param>
        /// <returns>Localized String</returns>
        public string GetValidText(string key)
        {
            return key.Trim();
        }
    }
}