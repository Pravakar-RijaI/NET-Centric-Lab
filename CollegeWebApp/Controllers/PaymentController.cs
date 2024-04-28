using Microsoft.AspNetCore.Mvc;

namespace CollegeWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        // GET: api/<ValuesController1>
        /*[HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { id = 25745, name = "Pravakar Rijal" });
        }

        // GET api/<ValuesController1>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController1>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
