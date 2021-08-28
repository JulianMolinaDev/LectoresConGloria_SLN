using Microsoft.AspNetCore.Mvc;

namespace LectoresConGloria_GW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Running";
        }
    }
}
