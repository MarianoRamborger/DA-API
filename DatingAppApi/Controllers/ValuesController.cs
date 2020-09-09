using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DatingAppApi.Controllers
{
    //This route is equivalent to http://localhost:5000/api
    //BUT! the content of the class (ValuesController) is replaced in the string below, inside Route 
    //MVC as inlcuded on startup routes the request (at that URL) to this controller.

    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
           //Below are the different verb+endpoints contemplated in the project..

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
