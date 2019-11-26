using System.Collections.Generic;

namespace Proxy
{
    /// <summary>
    /// Proxy for <see cref="TextValidator"/>.
    /// </summary>
    public class ChildTextValidator : ITextValidator
    {
        private ITextValidator service;
        private List<string> badWords;
        
        public ChildTextValidator(ITextValidator service)
        {
            this.service = service;
        }
        
        public string GetValidText(string word)
        {
            if (badWords.Contains(word))
            {
                return string.Empty;
            }

            return service.GetValidText(word);
        }
    }
}