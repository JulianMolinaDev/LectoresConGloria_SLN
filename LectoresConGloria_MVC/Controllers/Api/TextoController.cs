using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectoresConGloria_FWK.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LectoresConGloria_MVC.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextoController : ControllerBase
    {
        private readonly ISVC_Texto _servicio;
        public TextoController(ISVC_Texto servicio)
        {
            _servicio = servicio;
        }
        ActionResult GetUltimosPorFecha(DateTime fecha)
        {
            var model = _servicio.GetUltimosPorFecha(fecha);
            return Ok(model);
        }
        ActionResult GetUltimos()
        {
            var model = _servicio.GetUltimos();
            return Ok(model);
        }
        ActionResult GetMasClicks()
        {
            var model = _servicio.GetMasClicks();
            return Ok(model);
        }
    }
}
