using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUrlLogic
    {

        /// <summary>
        /// encodes a URL to a shortened URL.
        /// </summary>
        /// <param name="url"> Url we want to shorten </param>
        /// <returns>string of the url that has been shortend</returns>
        public string EncodeUrl(string url);


        /// <summary>
        /// decodes a shortened URL to its original URL.
        /// </summary>
        /// <param name="url"></param>
        /// <returns>string of the url that has been lengthend</returns>
        public string DecodeUrl(string url);

    }
}
