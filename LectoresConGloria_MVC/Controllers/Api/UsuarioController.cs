using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LectoresConGloria_MVC.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly ISVC_Usuario _servicio;
        public UsuarioController(ISVC_Usuario servicio)
        {
            _servicio = servicio;
        }

        public IActionResult Login(MDL_Login login)
        {
            var usuario = _servicio.Login(login);
            return Ok(usuario);
        }
        public IActionResult Register(MDL_Usuario reg)
        {
            var usuario = _servicio.Register(reg);
            return Ok(usuario);
        }
    }
}
