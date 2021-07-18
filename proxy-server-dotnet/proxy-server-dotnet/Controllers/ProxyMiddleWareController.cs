using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace proxy_server_dotnet.Controllers
{
    [ApiController]
    [Route("api/")]
    public class ProxyMiddleWareController : ControllerBase
    {

        [HttpGet]
        [Route("A")]
        public ActionResult<string> GetPublicIpA()
        {
            return "value";
        }

        [HttpGet]
        [Route("B")]
        public ActionResult<string> GetPublicIpB()
        {
            return "value";
        }

    }
}
