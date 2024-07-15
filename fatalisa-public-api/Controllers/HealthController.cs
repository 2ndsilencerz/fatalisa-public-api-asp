using Microsoft.AspNetCore.Mvc;
using fatalisa_public_api.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fatalisa_public_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthController(HealthService healthService) : ControllerBase
    {
        // GET: api/<HealthController>
        [HttpGet(Name = "GetHealth")]
        public string Get()
        {
            return healthService.GetHealth();
        }

        /*
        // GET api/<HealthController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<HealthController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HealthController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HealthController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        */
    }
}
