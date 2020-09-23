using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace LectoresConGloria_MVC.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClickController : ControllerBase
    {
        private readonly ISVC_Click _servicio;
        public ClickController(ISVC_Click servicio)
        {
            _servicio = servicio;
        }
        public IActionResult Write(MDL_Click click)
        {
            _servicio.Write(click);
            return Ok();
        }
    }
}
