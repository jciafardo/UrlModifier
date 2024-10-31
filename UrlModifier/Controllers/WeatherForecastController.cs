using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace UrlModifier.Controllers
{
    [ApiController]
    [Route("url")]
    public class UrlController : ControllerBase
    {
        private readonly IUrlLogic _urlLogic;

        public UrlController(IUrlLogic urlLogic)
        {
            _urlLogic = urlLogic;
        }


        [HttpGet("encode/{url}")]
        public IActionResult EncodeUrl(string url)
        {
            _urlLogic.EncodeUrl(url);

            return Ok("ok");
        }

        [HttpGet("decode/{url}")]
        public IActionResult DecodeUrl(string url)
        {
            _urlLogic.DecodeUrl(url);   
            return Ok("ok");
        }

    }
}
