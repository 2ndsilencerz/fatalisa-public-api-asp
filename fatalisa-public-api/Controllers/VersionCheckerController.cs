using fatalisa_public_api.Model;
using fatalisa_public_api.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace fatalisa_public_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionCheckerController(CommonService commonService) : ControllerBase
    {
        // GET: api/<VersionChecker>
        [HttpGet]
        public Body Get()
        {
            return commonService.Get();
        }
    }
}
