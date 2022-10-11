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
    public class LectoresController : ControllerBase
    {
        private readonly ISVC_Lector _servicio;
        public LectoresController(ISVC_Lector servicio)
        {
            _servicio = servicio;
        }
        // GET: api/<LectoresController>
        [HttpGet]
        public async Task<IEnumerable<MDL_Lector>> Get()
        {
            return await _servicio.Get();
        }

        // GET api/<LectoresController>/5
        [HttpGet("{id}")]
        public async Task<MDL_Lector> Get(int id)
        {
            return await _servicio.Get(id);
        }

        // POST api/<LectoresController>
        [HttpPost]
        public async Task Post([FromBody] MDL_Lector value)
        {
            await _servicio.Post(value);
        }

        // PUT api/<LectoresController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] MDL_Lector value)
        {
            await _servicio.Put(id, value);
        }

        // DELETE api/<LectoresController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _servicio.Delete(id);
        }
    }
}
