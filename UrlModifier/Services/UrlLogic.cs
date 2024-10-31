using Contracts;

namespace UrlModifier.Services
{
    /// <summary>
    /// Class <c>UrlLogic</c> Service responsible for encoding and decoding URLs
    /// </summary>
    public class UrlLogic : IUrlLogic

    {
        /// <summary>
        /// decodes a shortened URL to its original URL.
        /// </summary>
        /// <param name="url">url we want to decode</param>
        /// <returns>The original url before it was encoded</returns>
   
        public string DecodeUrl(string url)
        {
            return Uri.UnescapeDataString(url);
        }

        /// <summary>
        /// encodes a URL to a shortened URL.
        /// </summary>
        /// <param name="url">url we want to encode</param>
        /// <returns>The encoded url </returns>
        public string EncodeUrl(string url)
        {
            return Uri.EscapeDataString(url);
        }
    }
}
