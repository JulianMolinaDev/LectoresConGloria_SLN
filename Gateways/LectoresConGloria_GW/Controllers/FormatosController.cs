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
    public class FormatosController : ControllerBase
    {
        private readonly ISVC_Formato _servicio;
        public FormatosController(ISVC_Formato servicio)
        {
            _servicio = servicio;
        }
        // GET: api/<FormatosController>
        [HttpGet]
        public async Task<IEnumerable<MDL_Formato>> Get()
        {
            return await _servicio.Get();
        }

        // GET api/<FormatosController>/5
        [HttpGet("{id}")]
        public async Task<MDL_Formato> Get(int id)
        {
            return await _servicio.Get(id);
        }

        // POST api/<FormatosController>
        [HttpPost]
        public async Task Post([FromBody] MDL_Formato value)
        {
            await _servicio.Post(value);
        }

        // PUT api/<FormatosController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] MDL_Formato value)
        {
            await _servicio.Put(id, value);
        }

        // DELETE api/<FormatosController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _servicio.Delete(id);
        }
    }
}
