using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace UrlModifier.Controllers
{
    /// <summary>
    /// Class <c>UrlController</c> Controller responsible for encoding and decoding URLs
    /// </summary>
    [ApiController]
    [Route("url")]

    
    
    public class UrlController : ControllerBase
    {
        private readonly IUrlLogic _urlLogic;

        public UrlController(IUrlLogic urlLogic)
        {
            _urlLogic = urlLogic;
        }

        /// <summary>
        /// Enpoint to encode a URL
        /// </summary>
        /// <param name="url">url user wants to encode</param>
        /// <returns>encoded url in json</returns>

        [HttpGet("encode")]
        public IActionResult EncodeUrl([FromQuery] string url)
        {
            string encodedUrl = _urlLogic.EncodeUrl(url);

            if (encodedUrl is not null)
            {
                return new JsonResult(new {encodedUrl});
            }
            return BadRequest("Url user enterd was not valid");
        }

        /// <summary>
        /// Enpoint to decode a URL
        /// </summary>
        /// <param name="url">url user wants to decode</param>
        /// <returns>decoded url in json</returns>

        [HttpGet("decode")]
        public IActionResult DecodeUrl([FromQuery] string url)
        {
            string decodedUrl = _urlLogic.DecodeUrl(url);

            if (decodedUrl is not null)
            {
                return new JsonResult(new { decodedUrl });
            }
            return BadRequest("Url user enterd was not valid");
        }
    }

    }

