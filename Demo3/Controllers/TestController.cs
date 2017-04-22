using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo3.Controllers
{
    public class TestController : ApiController
    {
        // GET: api/Test
        public HttpResponseMessage Get()
        {
            //return new string[] { "value1", "value2" };
            var msg = "Get All Ok";
            return Request.CreateResponse(HttpStatusCode.OK, msg);
        }

        // GET: api/Test/5
        public HttpResponseMessage Get(int id)
        {
            var msg = "Get " + id + " Ok";
            return Request.CreateResponse(HttpStatusCode.BadRequest, msg);
        }

        // POST: api/Test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Test/5
        public void Delete(int id)
        {
        }
    }
}
