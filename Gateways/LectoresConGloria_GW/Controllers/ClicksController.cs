using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_FWK.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LectoresConGloria_GW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClicksController : ControllerBase, ISVC_Click
    {
        private readonly ISVC_Click _servicio;
        public ClicksController(ISVC_Click servicio)
        {
            _servicio = servicio;
        }
        

        // POST api/<ClicksController>
        [HttpPost]
        public async Task Write([FromBody] MDL_Click value)
        {
            await _servicio.Write(value);
        }
        
    }
}
