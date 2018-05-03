using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestAppRest.Controllers
{
    [RoutePrefix("api/tapi")]
    public class HomeController : ApiController
    {
        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}

        [HttpGet]
        [Route("Test")]
        public string Test([FromUri] string pInput)
        {
            string lResult = "Parameter = " + pInput;
            return lResult;
        }

        [HttpGet]
        [Route("Test2")]
        public string Test2()
        {
            string lResult = "Test 2";
            return lResult;
        }
    }
}