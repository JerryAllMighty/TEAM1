using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BedFactoryAPI.Controllers
{
    [RoutePrefix("api/Hello")]
    public class HelloController : ApiController
    {
        [Route("GetHello")]
        public IHttpActionResult GetHello() //api/Hello/GetHello
        {
            return Ok("Hello World");
        }
    }
}
